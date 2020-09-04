using System;
using System.Collections.Generic;

namespace Basics.Algorithms
{
    public interface ISorter<T> where T : IComparable<T>
    {
        IEnumerable<T> Sort(IEnumerable<T> original);
    }
}