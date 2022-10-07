using System;
using System.Linq.Expressions;

namespace WiangtaiMemberApp.Web.Commons.Extensions;

public static class QueryExtensions
{
    public static IQueryable<T> OrderByDirection<T, TKey>(this IQueryable<T> source, Expression<Func<T, TKey>> keySelector, bool ascendingOrder = true)
    {
        if (ascendingOrder)
        {
            return source.OrderBy(keySelector);
        }

        return source.OrderByDescending(keySelector);
    }
}
