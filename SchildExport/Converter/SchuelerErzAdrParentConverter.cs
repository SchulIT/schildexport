using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Converter
{
    public class SchuelerErzAdrParentConverter : IConverter<SchuelerErzAdr, Parent>
    {
        protected IConverter<Schueler, Student> studentConverter;

        internal void SetStudentConverter(IConverter<Schueler, Student> studentConverter)
        {
            this.studentConverter = studentConverter;
        }

        public Parent Convert(SchuelerErzAdr source)
        {
            var anreden = (new string[] { source.Anrede1, source.Anrede2 }).Where(x => !string.IsNullOrEmpty(x));
            var nachnamen = (new string[] { source.Name1, source.Name2 }).Where(x => !string.IsNullOrEmpty(x)).Distinct();

            return new Parent
            {
                Id = source.Id,
                Student = studentConverter.Convert(source.Schueler),
                Firstname = string.Join(" und ", anreden),
                Lastname = string.Join(" und ", nachnamen),
                Email = source.ErzEmail,
            };
        }
    }
}
