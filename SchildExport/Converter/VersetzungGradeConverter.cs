using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Converter
{
    class VersetzungGradeConverter : IConverter<Versetzung, Grade>
    {
        private SichtbarBooleanConverter sichtbarBooleanConverter = new SichtbarBooleanConverter();

        protected IEnumerable<TeacherRef> Teachers { get; private set; }

        internal void SetTeachers(IEnumerable<TeacherRef> teachers)
        {
            Teachers = teachers;
        }

        public virtual Grade Convert(Versetzung source)
        {
            return new Grade
            {
                Id = source.Id,
                Name = source.Klasse,
                Teacher = Teachers?.FirstOrDefault(t => t != null && t.Acronym == source.KlassenlehrerKrz),
                SubstituteTeacher = Teachers?.FirstOrDefault(t => t != null && t.Acronym == source.StvKlassenlehrerKrz),
                IsVisible = sichtbarBooleanConverter.Convert(source.Sichtbar)
            };
        }
    }
}
