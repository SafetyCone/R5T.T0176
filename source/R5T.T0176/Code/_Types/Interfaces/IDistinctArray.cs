using System;
using System.Collections.Generic;

using R5T.T0142;


namespace R5T.T0176
{
    /// <summary>
    /// Indicates (but does not guarantee) that an array contains distinct elements.
    /// External (or extension) methods can be used to verify/ensure that elements are actually distinct if desired (and the cost of computation is justified).
    /// </summary>
    /// <remarks>
    /// Conceptually similar to <see cref="IReadOnlyCollection{T}"/>, but indicates the property of being distict instead of being read-only.
    /// </remarks>
    [UtilityTypeMarker]
    public interface IDistinctArray<T> : IList<T>, ICollection<T>, IDistinctEnumerable<T>, IReadOnlyList<T>, IReadOnlyCollection<T>
    {
        T[] Array { get; }
    }
}
