using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Converter
{
    public class SchuelerStudentConverter : IConverter<Schueler, Student>
    {
        protected IEnumerable<Grade> Grades { get; private set; }

        protected GeschlechtGenderConverter GenderConverter { get; } = new GeschlechtGenderConverter();

        internal void SetGrades(IEnumerable<Grade> grades)
        {
            this.Grades = grades;
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
                Email = source.Email,
                Birthday = source.Geburtsdatum,
                Gender = GenderConverter.Convert(source.Geschlecht?.ToString()),
                Grade = Grades.FirstOrDefault(x => x.Name == source.Klasse)
            };
        }
    }
}
