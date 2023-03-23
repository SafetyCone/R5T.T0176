using System;
using System.Collections.Generic;

using R5T.T0176.Internal;


namespace R5T.T0176.Extensions
{
    public static class IEnumerableExtensions
    {
        /// <inheritdoc cref="IEnumerableOperator.AsDistinctEnumerable{T}(IEnumerable{T})"/>
        public static IDistinctEnumerable<T> AsDistinctEnumerable<T>(this IEnumerable<T> enumerable)
        {
            return Instances.EnumerableOperator.AsDistinctEnumerable(enumerable);
        }

        /// <inheritdoc cref="IEnumerableOperator.AsDistinctEnumerable{T}(IEnumerable{T})"/>
        public static DistinctArray<T> ToDistinctArray<T>(this IEnumerable<T> enumerable)
        {
            return Instances.EnumerableOperator.ToDistinctArray(enumerable);
        }
    }
}
