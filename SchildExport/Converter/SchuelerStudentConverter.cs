using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Converter
{
    class SchuelerStudentConverter : IConverter<Schueler, Student>
    {
        private const char IsFullageFlag = '+';

        protected IEnumerable<GradeRef> Grades { get; private set; }

        protected GeschlechtGenderConverter GenderConverter { get; } = new GeschlechtGenderConverter();

        internal void SetGrades(IEnumerable<GradeRef> grades)
        {
            Grades = grades;
        }

        public virtual Student Convert(Schueler source)
        {
            if(source == null)
            {
                return null;
            }

            return new Student
            {
                Id = source.Id,
                Firstname = source.Vorname,
                Lastname = source.Name,
                Email = source.SchulEmail,
                IsFullage = source.Volljaehrig == IsFullageFlag,
                Gender = GenderConverter.Convert(source.Geschlecht),
                Grade = Grades.FirstOrDefault(x => x.Name == source.Klasse),
                LeaveDate = source.Entlassdatum,
                Birthday = source.Geburtsdatum,
                Status = source.Status.ToString()
            };
        }
    }
}
