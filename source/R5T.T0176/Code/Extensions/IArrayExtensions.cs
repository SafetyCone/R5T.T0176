using System;

using R5T.T0176.Internal;


namespace R5T.T0176.Extensions
{
    public static class IArrayExtensions
    {
        /// <inheritdoc cref="IArrayOperator.AsDistinctArray{T}(T[])"/>
        public static IDistinctArray<T> AsDistinctArray<T>(this T[] array)
        {
            return Instances.ArrayOperator.AsDistinctArray(array);
        }
    }
}
