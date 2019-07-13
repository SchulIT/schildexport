using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Linq;

namespace SchildExport.Console
{
    public class CustomSchuelerStudentConverter : SchuelerStudentConverter
    {
        public override Student Convert(Schueler source)
        {
            return new CustomStudent
            {
                Id = source.Id,
                Firstname = source.Vorname,
                Lastname = source.Name,
                Email = source.Email,
                Birthday = source.Geburtsdatum,
                Gender = GenderConverter.Convert(source.Geschlecht?.ToString()),
                Grade = Grades.FirstOrDefault(x => x.Name == x.Name),
                ExternalId = source.Idext
            };
        }
    }
}
