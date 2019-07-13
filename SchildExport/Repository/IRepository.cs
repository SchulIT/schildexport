using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchulIT.SchildExport.Repository
{
    internal interface IRepository<TSource, TResult>
        where TSource : class
    {
        Task<List<TResult>> FindAllAsync(SchildNRWContext context, IConverter<TSource, TResult> converter);
    }
}
