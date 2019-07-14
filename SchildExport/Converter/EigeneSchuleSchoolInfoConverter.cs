using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Linq;

namespace SchulIT.SchildExport.Converter
{
    public class EigeneSchuleSchoolInfoConverter : IConverter<EigeneSchule, SchoolInfo>
    {
        public SchoolInfo Convert(EigeneSchule source)
        {
            var schoolInfo = new SchoolInfo
            {
                SchoolId = source.SchulNr,
                Name = source.Bezeichnung1,
                NumSections = source.AnzahlAbschnitte,
                CurrentSection = source.SchuljahrAbschnitt,
                CurrentYear = source.Schuljahr
            };

            schoolInfo.SectionLabels = (new string[] { source.BezAbschnitt1, source.BezAbschnitt2, source.BezAbschnitt3, source.BezAbschnitt4 })
                .Take(source.AnzahlAbschnitte)
                .ToArray();

            return schoolInfo;
        }
    }
}
