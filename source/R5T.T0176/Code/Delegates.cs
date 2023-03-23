using System;
using System.Collections.Generic;


namespace R5T.T0176
{
    /// <summary>
    /// Filters an enumerable to get a distinct enumerable.
    /// </summary>
    public delegate IDistinctEnumerable<T> DistinctFilter<T>(IEnumerable<T> enumerable);
}
