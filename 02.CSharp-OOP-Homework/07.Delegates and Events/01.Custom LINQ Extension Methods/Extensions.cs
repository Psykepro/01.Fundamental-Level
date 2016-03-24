using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Custom_LINQ_Extension_Methods
{
    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> condition)
        {
            List<T> resultList = new List<T>();
            foreach (var element in collection)
            {
                if (!condition(element))
                {
                    resultList.Add(element);
                }
            }
            return resultList;
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection,
            Func<TSource, TSelector> condition)where TSelector : IComparable
        {
            TSelector max = condition(collection.First());
            if (collection == null)
            {
                throw new InvalidOperationException("The collection is EMPTY !");
            }
            foreach (var element in collection)
            {
                if(max.CompareTo(condition(element))==-1)
                {
                    max = condition(element);
                }
            }
            return max;
        }
    }
}