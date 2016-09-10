using System.Linq;
using System.Collections.Generic;
using GameWork.Utilities;

namespace GameWork.Extensions
{
    public static class EnumerableExtensions
    {
        public static ICollection<TSource> Shuffle<TSource>(this IEnumerable<TSource> enumerable)
        {
            return enumerable.OrderBy(x => RandomUtil.Next()).ToList();
        }
    }
}