using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;

namespace SchulIT.SchildExport.Converter
{
    class EigeneSchueleFaecherSubjectConverter : IConverter<EigeneSchuleFaecher, Subject>
    {
        private SichtbarBooleanConverter sichtbarBooleanConverter = new SichtbarBooleanConverter();

        public virtual Subject Convert(EigeneSchuleFaecher source)
        {
            return new Subject
            {
                Id = source.Id,
                Abbreviation = source.FachKrz,
                Description = source.Bezeichnung,
                IsVisible = sichtbarBooleanConverter.Convert(source.Sichtbar)
            };
        }
    }
}
