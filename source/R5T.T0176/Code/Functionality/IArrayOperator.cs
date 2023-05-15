using System;

using R5T.T0132;

using R5T.T0176.Internal;


namespace R5T.T0176
{
    [FunctionalityMarker]
    public partial interface IArrayOperator : IFunctionalityMarker
    {
        /// <summary>
        /// Assumes the input <paramref name="array"/> is already distinct and simply wraps it in a distint array type.
        /// </summary>
        /// <param name="array">An array assumed to already be distinct.</param>
        public IDistinctArray<T> AsDistinctArray<T>(T[] array)
        {
            var output = new DistinctArray<T>(array);
            return output;
        }
    }
}
