using Microsoft.EntityFrameworkCore;
using SchulIT.SchildExport.Converter;
using SchulIT.SchildExport.Data;
using SchulIT.SchildExport.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchulIT.SchildExport.Repository
{
    internal abstract class Repository<TSource, TResult> : IRepository<TSource, TResult>
        where TSource : class
    {
        protected Task<List<TResult>> GetEntitiesAsync(IQueryable<TSource> dbSet, IConverter<TSource, TResult> converter)
        {
            return GetEntitiesAsync(dbSet, x => converter.Convert(x));
        }

        protected async Task<List<TResult>> GetEntitiesAsync(IQueryable<TSource> dbSet, Func<TSource, TResult> selector)
        {
            var entities = await dbSet.ToListAsync().ConfigureAwait(false);
            var dataTransferObjects = await entities.SelectAsync(selector).ConfigureAwait(false);

            return await dataTransferObjects.ToListAsync().ConfigureAwait(false);
        }

        public abstract Task<List<TResult>> FindAllAsync(SchildNRWContext context, IConverter<TSource, TResult> converter);
    }
}
