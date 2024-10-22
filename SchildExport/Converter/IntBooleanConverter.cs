using LinqToDB.Common;

namespace SchulIT.SchildExport.Converter
{
    public class IntBooleanConverter : ValueConverter<bool, int?>
    {
        public IntBooleanConverter() 
            : base(v => v ? 1 : 0, v => v != null && v == 1, true)
        {
        }
    }
}
