using System;
using System.Linq;

namespace MaximumSubarray
{
    public static class Calc
    {
        public static string GetMaximumSubarray(string arrayStr)
        {
            if (string.IsNullOrWhiteSpace(arrayStr)) throw new ArgumentException(nameof(arrayStr));
            var array = GetMaximumSubarray(arrayStr.Trim()
                .Split(new char[] { ';', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => int.Parse(s.Trim()))
                .ToArray());
            var result = "";
            foreach (var item in array)
                result += $"{item}, ";
            return $" [ {result.Trim(new char[] { ' ', ',' })} ] ";
        }

        public static int[] GetMaximumSubarray(int[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if (array.Length <= 1) return array;

            var max = int.MinValue;
            var subarray = (start: -1, end: -1, total: int.MinValue);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
                if (array[i] <= 0) continue;
                for (int j = i; j < array.Length; j++)
                {
                    var total = 0;
                    for (int k = i; k <= j; k++)
                        total += array[k];
                    if (total >= subarray.total && (j - i) < (subarray.end - subarray.start))
                        subarray = (i, j, total);
                }
            }
            if (subarray.start >= 0)
            {
                var result = new int[subarray.end];
                var index = 0;
                for (int i = subarray.start; i <= subarray.end; i++)
                    result[index++] = array[i];
                Array.Resize(ref result, index);
                return result;
            }
            return new int[] { max };
        }
    }
}
