using SchulIT.SchildExport.Models;

namespace SchulIT.SchildExport.Converter
{
    public class GeschlechtGenderConverter : IConverter<string, Gender>
    {
        public virtual Gender Convert(string source)
        {
            if (source == "3")
            {
                return Gender.Male;
            }
            else if (source == "4")
            {
                return Gender.Female;
            }

            return Gender.Other;
        }
    }
}
