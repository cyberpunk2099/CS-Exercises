using System;
using System.Linq;

namespace MaximumSubarray
{
    /// <summary>
    /// Kadane's Algorithm
    /// Source <see cref="https://www.youtube.com/watch?v=86CQq3pKSUw"/>
    /// </summary>
    public static class KadanesAlgorithm
    {
        public static int[] GetMaximumSubarray(int[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if (array.Length <= 1) return array;
            var a    = array.AsSpan();
            var curr = (array: a.Slice(0, 1).ToArray(), total: a[0]);
            var max  = curr;
            for (int i = 1; i < a.Length; i++)
            {
                var slice = a.Slice(i, 1).ToArray();
                if (a[i] > curr.total + a[i])
                    curr = (array: slice, total: a[i]);
                else
                    curr = (
                        array: curr.array.Union(slice).ToArray(),
                        total: curr.total + a[i]);
                if (curr.total > max.total) max = curr;
            }
            return max.array;
        }
    }
}
