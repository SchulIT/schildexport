using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchulIT.SchildExport.Converter
{
    class KLehrerTeacherConverter : IConverter<KLehrer, Teacher>
    {
        protected GeschlechtGenderConverter GenderConverter { get; } = new GeschlechtGenderConverter();

        protected LehrerabschnittsDatenTeacherSectionDataConverter TeacherDataConverter { get; } = new LehrerabschnittsDatenTeacherSectionDataConverter();

        private SichtbarBooleanConverter sichtbarBooleanConverter = new SichtbarBooleanConverter();

        public virtual Teacher Convert(KLehrer source)
        {
            if (source == null)
            {
                return null;
            }

            return new Teacher
            {
                Id = source.Id,
                Acronym = source.Kuerzel,
                Firstname = source.Vorname,
                Lastname = source.Nachname,
                Title = source.Titel,
                Gender = GenderConverter.Convert(source.Geschlecht),
                Email = source.EmailDienstlich,
                SectionData = source.Abschnittsdaten?.Select(x => TeacherDataConverter.Convert(x)).ToArray(),
                IsVisible = sichtbarBooleanConverter.Convert(source.Sichtbar)
            };
        }
    }
}
