using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;

namespace SchulIT.SchildExport.Converter
{
    class LehrerabschnittsDatenTeacherSectionDataConverter : IConverter<LehrerAbschnittsdaten, TeacherSectionData>
    {
        public TeacherSectionData Convert(LehrerAbschnittsdaten source)
        {
            return new TeacherSectionData
            {
                Section = source.Abschnitt,
                Year = source.Jahr,
                LegalRelationship = source.Rechtsverhaeltnis
            };
        }
    }
}
