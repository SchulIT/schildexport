namespace SchulIT.SchildExport.Converter
{
    interface IConverter<TSource, TResult>
    {
        TResult Convert(TSource source);
    }
}
