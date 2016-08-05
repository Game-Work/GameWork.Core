using System;
using System.Linq;
using System.Collections.Generic;
using GameWork.Utilities;

public static class IEnumerableExtensions
{
    public static ICollection<TSource> Shuffle<TSource>(this IEnumerable<TSource> enumerable)
    {
        return enumerable.OrderBy(x => RandUtil.Next()).ToList();
    }
}