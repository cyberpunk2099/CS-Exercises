using System;

namespace SortingAlgorithms
{
    public static class SortExtensions
    {
        public static void SelectionSort<T>(this T[] a) where T : IComparable<T>
        {
            if (a == null || a.Length <= 1) return;
            var p = 0;
            while (p < a.Length - 1)
            {
                var min = p;
                for (int i = p + 1; i < a.Length; i++)
                {
                    if (a[i].CompareTo(a[min]) < 0)
                        min = i;
                }
                if (a[min].CompareTo(a[p]) < 0)
                    (a[min], a[p]) = (a[p], a[min]);
                p++;
            }
        }
    }
}
