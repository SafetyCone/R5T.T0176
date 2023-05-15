using System;

using R5T.T0142;
using R5T.T0174;


namespace R5T.T0176.Internal
{
    [UtilityTypeMarker]
    public class DistinctArray<T> : ArrayWrapper<T>, IDistinctArray<T>
    {
        public DistinctArray(T[] array)
            : base(array)
        {
        }

        T[] IDistinctArray<T>.Array => this;
    }
}
