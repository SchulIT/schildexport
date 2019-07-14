using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Converter
{
    public class KurseCourseConverter : IConverter<Kurse, Course>
    {
        protected List<Subject> Subjects { get; private set; }

        protected List<Teacher> Teachers { get; private set; }

        internal void SetSubjects(List<Subject> subjects)
        {
            Subjects = subjects;
        }

        internal void SetTeachers(List<Teacher> teachers)
        {
            Teachers = teachers;
        }

        public Course Convert(Kurse source)
        {
            var course = new Course
            {
                Id = source.Id,
                Name = source.KurzBez,
                Type = source.KursartAllg,
                Subject = Subjects?.FirstOrDefault(s => s.Id == source.FachId),
                Year = source.Jahr,
                Section = source.Abschnitt,
                Teacher = Teachers?.FirstOrDefault(t => t.Abbreviation == source.LehrerKrz)
            };

            return course;
        }
    }
}
