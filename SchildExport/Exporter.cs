using Microsoft.EntityFrameworkCore;
using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using SchulIT.SchildExport.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchulIT.SchildExport
{
    public class Exporter : IExporter
    {
        private DatabaseType databaseType;
        private string connectionString = null;

        private SchildNRWContext GetContext()
        {
            if (connectionString == null)
            {
                throw new InvalidOperationException("You must configure the exporter using the Configure() method first.");
            }

            var optionsBuilder = new DbContextOptionsBuilder<SchildNRWContext>();

            if (databaseType == DatabaseType.MSSQL)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
            else if (databaseType == DatabaseType.MySQL)
            {
                optionsBuilder.UseMySql(connectionString);
            }

            return new SchildNRWContext(optionsBuilder.Options);
        }

        public void Configure(DatabaseType databaseType, string connectionString)
        {
            this.databaseType = databaseType;
            this.connectionString = connectionString;
        }

        public Task<List<Subject>> GetSubjectsAsync()
        {
            return GetSubjectsAsync(new EigeneSchueleFaecherSubjectConverter());
        }

        public Task<List<Subject>> GetSubjectsAsync(IConverter<EigeneSchuleFaecher, Subject> converter)
        {
            return GetAsync(new SubjectRepository(), converter);
        }

        public Task<List<Teacher>> GetTeachersAsync(bool onlyVisible = true)
        {
            return GetTeachersAsync(onlyVisible, new KLehrerTeacherConverter());
        }

        public Task<List<Teacher>> GetTeachersAsync(bool onlyVisible, IConverter<KLehrer, Teacher> converter)
        {
            return GetAsync(new TeacherRepository(onlyVisible), converter);
        }

        public Task<List<Grade>> GetGradesAsync()
        {
            return GetGradesAsync(new VersetzungGradeConverter(), new KLehrerTeacherConverter());
        }

        public async Task<List<Grade>> GetGradesAsync(IConverter<Versetzung, Grade> converter, IConverter<KLehrer, Teacher> teacherConverter)
        {
            var versetzungsGradeConverter = converter as VersetzungGradeConverter;

            if (versetzungsGradeConverter != null)
            {
                var teachers = await GetTeachersAsync(false, teacherConverter).ConfigureAwait(false);
                versetzungsGradeConverter.SetTeachers(teachers);
            }

            return await GetAsync(new GradeRepository(), converter).ConfigureAwait(false);
        }

        public Task<List<TeacherSubjects>> GetTeacherSubjectsAsync(bool onlyVisibleTeachers = true)
        {
            return GetTeacherSubjectsAsync(onlyVisibleTeachers, new KLehrerNullConverter(), new EigeneSchueleFaecherSubjectConverter());
        }

        public async Task<List<TeacherSubjects>> GetTeacherSubjectsAsync(bool onlyVisibleTeachers, IConverter<KLehrer, Teacher> teacherConverter, IConverter<EigeneSchuleFaecher, Subject> subjectConverter)
        {
            var teachers = await GetTeachersAsync(onlyVisibleTeachers, teacherConverter).ConfigureAwait(false);
            var subjects = await GetSubjectsAsync(subjectConverter).ConfigureAwait(false);

            return await GetAsync(new TeacherSubjectRepository(teachers, subjects), null);
        }

        private async Task<List<TResult>> GetAsync<TSource, TResult>(IRepository<TSource, TResult> repository, IConverter<TSource, TResult> converter)
            where TSource : class
        {
            using (var context = GetContext())
            {
                return await repository.FindAllAsync(context, converter).ConfigureAwait(false);
            }
        }

        public Task<List<Student>> GetStudentsAsync()
        {
            return GetStudentsAsync(new SchuelerStudentConverter(), new VersetzungGradeConverter(), new KLehrerTeacherConverter());
        }

        public async Task<List<Student>> GetStudentsAsync(IConverter<Schueler, Student> converter, IConverter<Versetzung, Grade> gradeConverter, IConverter<KLehrer, Teacher> teacherConverter)
        {
            var schuelerStudentConverter = converter as SchuelerStudentConverter;

            if(schuelerStudentConverter != null)
            {
                var grades = await GetGradesAsync(gradeConverter, teacherConverter).ConfigureAwait(false);
                schuelerStudentConverter.SetGrades(grades);
            }

            return await GetAsync(new StudentRepository(), converter);
        }

        public Task<List<Parent>> GetParentsAsync()
        {
            return GetParentsAsync(new SchuelerErzAdrParentConverter(), new SchuelerStudentConverter(), new VersetzungGradeConverter());
        }

        public async Task<List<Parent>> GetParentsAsync(IConverter<SchuelerErzAdr, Parent> converter, IConverter<Schueler, Student> studentConverter, IConverter<Versetzung, Grade> gradeConverter)
        {
            var schuelerErzAdrParentConverter = converter as SchuelerErzAdrParentConverter;

            if(schuelerErzAdrParentConverter != null)
            {
                schuelerErzAdrParentConverter.SetStudentConverter(studentConverter);
            }

            if(studentConverter is SchuelerStudentConverter)
            {
                var grades = await GetGradesAsync(gradeConverter, new KLehrerNullConverter()).ConfigureAwait(false);
                (studentConverter as SchuelerStudentConverter).SetGrades(grades);
            }

            return await GetAsync(new ParentRepository(), converter);
        }

        public Task<List<Course>> GetCoursesAsync(int? year, int? section)
        {
            return GetCoursesAsync(year, section, new KurseCourseConverter(), new SchuelerLeistungsdatenStudentMembershipConverter(), new KLehrerTeacherConverter(), new EigeneSchueleFaecherSubjectConverter(), new VersetzungGradeConverter(), new SchuelerStudentConverter());
        }

        public async Task<List<Course>> GetCoursesAsync(int? year, int? section, IConverter<Kurse, Course> converter, IConverter<SchuelerLeistungsdaten, StudentCourseMembership> membershipConverter, IConverter<KLehrer, Teacher> teacherConverter, IConverter<EigeneSchuleFaecher, Subject> subjectConverter, IConverter<Versetzung, Grade> gradeConverter, IConverter<Schueler, Student> studentConverter)
        {
            var students = await GetStudentsAsync(studentConverter, gradeConverter, new KLehrerNullConverter()).ConfigureAwait(false);
            var grades = await GetGradesAsync(gradeConverter, new KLehrerNullConverter()).ConfigureAwait(false);
            var teachers = await GetTeachersAsync(false, teacherConverter).ConfigureAwait(false);
            var subjects = await GetSubjectsAsync(subjectConverter).ConfigureAwait(false);

            var kurseCourseconverter = converter as KurseCourseConverter;

            if(kurseCourseconverter != null)
            {
                kurseCourseconverter.SetSubjects(subjects);
                kurseCourseconverter.SetTeachers(teachers);
            }

            if (membershipConverter is SchuelerLeistungsdatenStudentMembershipConverter)
            {
                (membershipConverter as SchuelerLeistungsdatenStudentMembershipConverter).SetStudents(students);
            }

            return await GetAsync(new CourseRepository(year, section, grades, teachers, subjects, membershipConverter), converter);
        }
    }
}
