using System;
using System.Diagnostics;
using System.Linq;

namespace MaximumSubarray
{
    public static class Helper
    {
        public static string GetMaximumSubarray(string arrayStr)
        {
            if (string.IsNullOrWhiteSpace(arrayStr)) throw new ArgumentException(nameof(arrayStr));
            var start = Environment.TickCount;
            try
            {
                var array =
                    //MyAlgorithm.GetMaximumSubarray(arrayStr.Trim()
                    KadanesAlgorithm.GetMaximumSubarray(arrayStr.Trim()
                        .Split(new char[] { ';', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => int.Parse(s.Trim()))
                        .ToArray());
                var result = "";
                foreach (var item in array)
                    result += $"{item}, ";
                return $" [ {result.Trim(new char[] { ' ', ',' })} ] ";
            }
            finally
            {
                Debug.WriteLine($"{Environment.TickCount - start} ms");
            }
        }
    }
}
