namespace SchulIT.SchildExport.Converter
{
    class SichtbarBooleanConverter : IConverter<char?, bool>
    {
        private const char VisibleValue = '+';

        public bool Convert(char? source)
        {
            return source.HasValue && source == VisibleValue;
        }
    }
}
