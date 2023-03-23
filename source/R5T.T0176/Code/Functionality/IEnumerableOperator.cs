using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;

using R5T.T0176.Extensions;
using R5T.T0176.Internal;


namespace R5T.T0176
{
    [FunctionalityMarker]
    public partial interface IEnumerableOperator : IFunctionalityMarker
    {
        /// <summary>
        /// Assumes the input <paramref name="enumerable"/> is already distinct and simply wraps it in a distint enumerable type.
        /// </summary>
        /// <param name="enumerable">An enumerable assumed to already be distinct.</param>
        public IDistinctEnumerable<T> AsDistinctEnumerable<T>(IEnumerable<T> enumerable)
        {
            var output = new DistinctEnumerable<T>(enumerable);
            return output;
        }

        /// <summary>
        /// Assumes the input <paramref name="enumerable"/> is already distinct and simply wraps it in a distint enumerable type.
        /// </summary>
        /// <param name="enumerable">An enumerable assumed to already be distinct.</param>
        public DistinctArray<T> ToDistinctArray<T>(IEnumerable<T> enumerable)
        {
            var array = enumerable.ToArray();

            var output = array.AsDistinctArray();
            return output;
        }
    }
}
