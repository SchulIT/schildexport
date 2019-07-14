using Microsoft.EntityFrameworkCore;
using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchulIT.SchildExport.Repository
{
    internal class CourseRepository : Repository<Kurse, Course>
    {
        private int? year;
        private int? section;

        private IEnumerable<Grade> grades;
        private IEnumerable<Teacher> teachers;
        private IEnumerable<Subject> subjects;

        private IConverter<SchuelerLeistungsdaten, StudentCourseMembership> courseMembershipConverter;

        public CourseRepository(int? year, int? section, IEnumerable<Grade> grades, IEnumerable<Teacher> teachers, IEnumerable<Subject> subjects, IConverter<SchuelerLeistungsdaten, StudentCourseMembership> courseMembershipConverter)
        {
            this.year = year;
            this.section = section;
            this.grades = grades;
            this.teachers = teachers;
            this.subjects = subjects;
            this.courseMembershipConverter = courseMembershipConverter;
        }

        private Task<List<Course>> GetCoursesAsync(SchildNRWContext context, IConverter<Kurse, Course> converter)
        {
            var query = context.Kurse;

            if(year.HasValue)
            {
                query.Where(x => x.Jahr == year.Value);
            }

            if(section.HasValue)
            {
                query.Where(x => x.Abschnitt == section.Value);
            }

            return GetEntitiesAsync(query, converter);
        }

        private List<SchuelerLeistungsdaten> GetLeistungsdaten(SchildNRWContext context)
        {
            var leistungsdatenQuery = context.SchuelerLeistungsdaten.Include(x => x.Abschnitt).Include(x => x.Kurs).Include(x => x.Fach);

            if (year.HasValue)
            {
                leistungsdatenQuery.Where(x => x.Abschnitt.Jahr == year.Value);
            }

            if (section.HasValue)
            {
                leistungsdatenQuery.Where(x => x.Abschnitt.Abschnitt == section);
            }

            return leistungsdatenQuery.ToList();
        }

        private Dictionary<int, int[]> GetAdditionalTeachers(SchildNRWContext context, IEnumerable<int> kursIds)
        {
            var kursLehrer = context.KursLehrer.Where(x => kursIds.Contains(x.KursId)).ToList();
            var result = kursLehrer.GroupBy(x => x.KursId).ToDictionary(x => x.Key, x => x.Select(y => y.LehrerId).ToArray());

            return result;
        }

        public override async Task<List<Course>> FindAllAsync(SchildNRWContext context, IConverter<Kurse, Course> converter)
        {
            /*
             * Vorgehensweise: da SchILD vom Schüler ausgeht, müssen wir zunächst die Kurse aus der Datenbank holen
             * und anschließend mithilfe der Leistungsdaten die Schüler zuordnen.
             * 
             * Für den Fall, dass ein Unterricht kein Kurs ist (bspw. Klassenunterricht Mathematik), muss der Kurs anhand
             * der Leistungsdaten der Schüler rekonstruiert werden.
             * 
             * Lasset die Party beginnen 🎉
             * 
             * Mögliche Bugs ergeben sich im Übrgen durch die nicht normalisierte Datenbank. 
             */

            var courses = await GetCoursesAsync(context, converter).ConfigureAwait(false);

            return await Task.Run(() =>
            {
                var leistungsdaten = GetLeistungsdaten(context);
                var additionalTeachers = GetAdditionalTeachers(context, courses.Select(x => x.Id));

                SetCourseInfo(context, courses, leistungsdaten, additionalTeachers);
                courses.AddRange(GetNonCourses(context, leistungsdaten));

                return courses;
            }).ConfigureAwait(false);
        }

        private void SetCourseInfo(SchildNRWContext context, List<Course> courses, List<SchuelerLeistungsdaten> leistungsdaten, Dictionary<int, int[]> additionalTeachers)
        {
            foreach (var course in courses)
            {
                // Add students
                var students = leistungsdaten.Where(x => x.KursId == course.Id);

                foreach (var studentInCourse in students)
                {
                    var membership = courseMembershipConverter.Convert(studentInCourse);

                    if(membership.Student != null)
                    {
                        course.Students.Add(membership);
                    }
                }

                // Add grades
                foreach(var membership in course.Students)
                {
                    if(!course.Grades.Contains(membership.Student.Grade))
                    {
                        course.Grades.Add(membership.Student.Grade);
                    }
                }

                // Add additional teachers (if necessary)
                if(additionalTeachers.ContainsKey(course.Id))
                {
                    foreach(var additionalTeacher in additionalTeachers[course.Id])
                    {
                        var teacher = teachers.FirstOrDefault(x => x.Id == additionalTeacher);

                        if(teacher != null)
                        {
                            course.AdditionalTeacher.Add(teacher);
                        }
                    }
                }
            }
        }

        private List<Course> GetNonCourses(SchildNRWContext context, List<SchuelerLeistungsdaten> leistungsdaten)
        {
            var leistungsdatenOhneKurs = leistungsdaten.Where(x => x.KursId == null);
            var kurse = leistungsdatenOhneKurs.GroupBy(x => new { x.FachId, x.Abschnitt.Jahr, x.Abschnitt.Abschnitt, x.Abschnitt.Klasse, x.Kursart, x.FachLehrer }).ToDictionary(x => x.Key, x => x.ToList());

            var courses = new List<Course>();

            foreach(var kurs in kurse)
            {
                var kursInfo = kurs.Key;
                var kursLeistungsdaten = kurs.Value;

                var course = new Course
                {
                    Id = -1,
                    Name = null,
                    Year = kursInfo.Jahr,
                    Section = kursInfo.Abschnitt,
                    Type = kursInfo.Kursart,
                    Teacher = teachers.FirstOrDefault(x => x.Abbreviation == kursInfo.FachLehrer),
                    Subject = subjects.FirstOrDefault(x => x.Id == kursInfo.FachId)
                };

                // Set grade
                var grade = grades.FirstOrDefault(x => x.Name == kursInfo.Klasse);

                if(grade != null)
                {
                    course.Grades.Add(grade);
                }

                // Add students
                foreach (var studentInCourse in kursLeistungsdaten)
                {
                    var membership = courseMembershipConverter.Convert(studentInCourse);

                    if (membership.Student != null)
                    {
                        course.Students.Add(membership);
                    }
                }

                courses.Add(course);
            }

            return courses;
        }

    }
}
