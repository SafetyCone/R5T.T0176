using System;
using System.Collections.Generic;


namespace R5T.T0176
{
    /// <summary>
    /// Indicates (but does not guarantee) that an enumerable contains distinct elements.
    /// External (or extension) methods can be used to verify/ensure that elements are actually distinct if desired (and the cost of computation is justified).
    /// </summary>
    /// <remarks>
    /// Conceptually similar to <see cref="IReadOnlyCollection{T}"/>, but indicates the property of being distict instead of being read-only.
    /// </remarks>
    public interface IDistinctEnumerable<out T> : IEnumerable<T>
    {
    }
}
