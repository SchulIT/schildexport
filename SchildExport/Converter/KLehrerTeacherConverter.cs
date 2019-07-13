using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;

namespace SchulIT.SchildExport.Converter
{
    public class KLehrerTeacherConverter : IConverter<KLehrer, Teacher>
    {
        protected GeschlechtGenderConverter GenderConverter { get; } = new GeschlechtGenderConverter();

        public virtual Teacher Convert(KLehrer source)
        {
            return new Teacher
            {
                Id = source.Id,
                Abbreviation = source.Kuerzel,
                Firstname = source.Vorname,
                Lastname = source.Nachname,
                Title = source.Titel,
                Gender = GenderConverter.Convert(source.Geschlecht),
                Email = source.Email
            };
        }
    }
}
