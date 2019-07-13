using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;

namespace SchildExport.Console
{
    public class CustomKLehrerTeacherConverter : KLehrerTeacherConverter
    {
        public override Teacher Convert(KLehrer source)
        {
            return new Teacher
            {
                Id = source.Id,
                Abbreviation = source.Kuerzel,
                Firstname = source.Vorname,
                Lastname = source.Nachname,
                Title = source.Titel,
                Gender = GenderConverter.Convert(source.Geschlecht),
                Email = source.EmailDienstlich
            };
        }
    }
}
