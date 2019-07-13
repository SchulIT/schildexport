using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;

namespace SchulIT.SchildExport.Converter
{
    public class EigeneSchueleFaecherSubjectConverter : IConverter<EigeneSchuleFaecher, Subject>
    {
        public virtual Subject Convert(EigeneSchuleFaecher source)
        {
            return new Subject
            {
                Id = source.Id,
                Abbreviation = source.FachKrz,
                Description = source.Bezeichnung
            };
        }
    }
}
