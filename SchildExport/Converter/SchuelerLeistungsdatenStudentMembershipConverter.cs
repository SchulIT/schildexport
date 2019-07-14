using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Converter
{
    public class SchuelerLeistungsdatenStudentMembershipConverter : IConverter<SchuelerLeistungsdaten, StudentCourseMembership>
    {
        protected IEnumerable<Student> Students { get; private set; }

        internal void SetStudents(IEnumerable<Student> students)
        {
            Students = students;
        }

        public StudentCourseMembership Convert(SchuelerLeistungsdaten source)
        {
            return new StudentCourseMembership
            {
                Student = Students.FirstOrDefault(x => x.Id == source.Id),
                Type = source.Kursart
            };
        }
    }
}
