using System;

namespace MaximumSubarray
{
    public static class MyAlgorithm
    {
        public static int[] GetMaximumSubarray(int[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if (array.Length <= 1) return array;

            var a   = array.AsSpan();
            var max = int.MinValue;
            var sub = (array: Array.Empty<int>(), total: int.MinValue);

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max) max = a[i];
                if (a[i] <= 0) continue; // skip if not greater than zero!
                for (int j = i; j < a.Length; j++)
                {
                    var sum = 0;
                    for (int k = i; k <= j; k++)
                        sum += a[k];
                    if (sum > sub.total || (sum == sub.total && (j - i) < (sub.array.Length)))
                        sub = (a.Slice(i, j - i + 1).ToArray(), sum);
                }
            }
            return sub.array.Length > 0
                ? sub.array
                : new int[] { max };
        }
    }
}
