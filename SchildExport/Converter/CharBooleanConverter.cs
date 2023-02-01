using LinqToDB.Common;

namespace SchulIT.SchildExport.Converter
{
    public class CharBooleanConverter : ValueConverter<bool, char?>
    {
        public CharBooleanConverter() 
            : base(v => v ? '+' : '-', v => v != null && v == '+', true)
        {
        }
    }
}
