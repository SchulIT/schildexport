using System.Collections.Generic;
using System.Threading.Tasks;
using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;

namespace SchulIT.SchildExport
{
    public interface IExporter
    {
        void Configure(DatabaseType databaseType, string connectionString);
        Task<List<Grade>> GetGradesAsync();
        Task<List<Grade>> GetGradesAsync(IConverter<Versetzung, Grade> converter, IConverter<KLehrer, Teacher> teacherConverter);
        Task<List<Subject>> GetSubjectsAsync();
        Task<List<Subject>> GetSubjectsAsync(IConverter<EigeneSchuleFaecher, Subject> converter);
        Task<List<Teacher>> GetTeachersAsync(bool onlyVisible = true);

        Task<List<Teacher>> GetTeachersAsync(bool onlyVisible, IConverter<KLehrer, Teacher> converter);
        Task<List<TeacherSubjects>> GetTeacherSubjectsAsync(bool onlyVisibleTeachers = true);
        Task<List<TeacherSubjects>> GetTeacherSubjectsAsync(bool onlyVisibleTeachers, IConverter<KLehrer, Teacher> teacherConverter, IConverter<EigeneSchuleFaecher, Subject> subjectConverter);

        Task<List<Student>> GetStudentsAsync();

        Task<List<Student>> GetStudentsAsync(IConverter<Schueler, Student> converter, IConverter<Versetzung, Grade> gradeConverter, IConverter<KLehrer, Teacher> teacherConverter);

        Task<List<Parent>> GetParentsAsync();

        Task<List<Parent>> GetParentsAsync(IConverter<SchuelerErzAdr, Parent> converter, IConverter<Schueler, Student> studentConverter, IConverter<Versetzung, Grade> gradeConverter);

        Task<List<Course>> GetCoursesAsync(int? year, int? section);

        Task<List<Course>> GetCoursesAsync(int? year, int? section, IConverter<Kurse, Course> converter, IConverter<SchuelerLeistungsdaten, StudentCourseMembership> membershipConverter, IConverter<KLehrer, Teacher> teacherConverter, IConverter<EigeneSchuleFaecher, Subject> subjectConverter, IConverter<Versetzung, Grade> gradeConverter, IConverter<Schueler, Student> studentConverter);
    }
}