using System;
using System.Collections.Generic;


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
        public static IDistinctArray<T> ToDistinctArray<T>(this IEnumerable<T> enumerable)
        {
            return Instances.EnumerableOperator.ToDistinctArray(enumerable);
        }

        /// <inheritdoc cref="IEnumerableOperator.ToDistinctEnumerable{T}(IEnumerable{T})"/>
        public static IDistinctEnumerable<T> ToDistinctEnumerable<T>(this IEnumerable<T> enumerable)
        {
            return Instances.EnumerableOperator.ToDistinctEnumerable(enumerable);
        }

        /// <inheritdoc cref="IEnumerableOperator.ToDistinctEnumerable{T}(IEnumerable{T}, IEqualityComparer{T})"/>
        public static IDistinctEnumerable<T> ToDistinctEnumerable<T>(this IEnumerable<T> enumerable,
            IEqualityComparer<T> equalityComparer)
        {
            return Instances.EnumerableOperator.ToDistinctEnumerable(
                enumerable,
                equalityComparer);
        }
    }
}
