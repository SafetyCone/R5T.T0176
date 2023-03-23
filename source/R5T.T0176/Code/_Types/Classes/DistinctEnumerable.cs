using System;
using System.Collections.Generic;

using R5T.T0142;
using R5T.T0174;


namespace R5T.T0176.Internal
{
    [UtilityTypeMarker]
    public class DistinctEnumerable<T> : EnumerableWrapper<T>, IDistinctEnumerable<T>
    {
        public DistinctEnumerable(IEnumerable<T> enumerable)
            : base(enumerable)
        {
        }
    }
}
