using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;

namespace SchulIT.SchildExport.Converter
{
    class EigeneSchuleSchoolInfoConverter : IConverter<EigeneSchule, SchoolInfo>
    {
        public SchoolInfo Convert(EigeneSchule source)
        {
            var schoolInfo = new SchoolInfo
            {
                SchoolId = source.SchulNr,
                Name = source.Bezeichnung1,
                CurrentSection = source.SchuljahrAbschnitt,
                CurrentYear = source.Schuljahr
            };

            return schoolInfo;
        }
    }
}
