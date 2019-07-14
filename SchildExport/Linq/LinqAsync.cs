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

        internal static Task<IEnumerable<TSource>> WhereAsync<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            return Task.Run(() => source.Where(predicate));
        }

        internal static Task<IEnumerable<TResult>> DistinctAsync<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            return Task.Run(() => source.Select(selector).Distinct());
        }

        internal static Task<IEnumerable<TSource>> DistinctAsync<TSource>(this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
        {
            return Task.Run(() => source.Distinct(comparer));
        }
    }
}
