using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Converter
{
    public class VersetzungGradeConverter : IConverter<Versetzung, Grade>
    {
        protected IEnumerable<Teacher> Teachers { get; private set; }

        internal void SetTeachers(IEnumerable<Teacher> teachers)
        {
            Teachers = teachers;
        }

        public virtual Grade Convert(Versetzung source)
        {
            return new Grade
            {
                Id = source.Id,
                Name = source.Klasse,
                Teacher = Teachers?.FirstOrDefault(t => t != null && t.Abbreviation == source.KlassenlehrerKrz),
                SubstitudeTeacher = Teachers?.FirstOrDefault(t => t != null && t.Abbreviation == source.StvKlassenlehrerKrz)
            };
        }
    }
}
