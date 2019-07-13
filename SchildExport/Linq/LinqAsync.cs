using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchulIT.SchildExport.Linq
{
    internal static class LinqAsync
    {
        internal static Task<IEnumerable<TResult>> SelectAsync<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            return Task.Run(() => source.Select(selector));
        }

        internal static Task<List<TSource>> ToListAsync<TSource>(this IEnumerable<TSource> source)
        {
            return Task.Run(() => source.ToList());
        }
    }
}
