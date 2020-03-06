using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;

namespace SchulIT.SchildExport.Converter
{
    class KDatenschutzPrivacyCategoryConverter : IConverter<KDatenschutz, PrivacyCategory>
    {
        private SichtbarBooleanConverter sichtbarBooleanConverter = new SichtbarBooleanConverter();

        public PrivacyCategory Convert(KDatenschutz source)
        {
            return new PrivacyCategory
            {
                Id = source.Id,
                Label = source.Bezeichnung,
                Description = source.Beschreibung,
                IsVisible = sichtbarBooleanConverter.Convert(source.Sichtbar)
            };
        }
    }
}
