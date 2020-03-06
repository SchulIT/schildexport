using SchulIT.SchildExport.Entities;
using SchulIT.SchildExport.Models;

namespace SchulIT.SchildExport.Converter
{
    class GeschlechtGenderConverter : IConverter<Geschlecht, Gender>
    {
        public Gender Convert(Geschlecht source)
        {
            switch (source)
            {
                case Geschlecht.Maennlich:
                    return Gender.Male;

                case Geschlecht.Weiblich:
                    return Gender.Female;

                default:
                    return Gender.Other;
            }
        }
    }
}
