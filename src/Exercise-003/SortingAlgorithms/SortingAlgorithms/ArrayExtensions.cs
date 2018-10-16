using System;

namespace SortingAlgorithms
{
    public static class ArrayExtensions
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

        public static string ToShortText<T>(this T[] a)
        {
            if (a == null) return string.Empty;
            switch (a.Length)
            {
                case 0:
                    return "[]";
                case 1:
                    return $"[{a[0]}]";
                case 2:
                    return $"[{a[0]}, {a[1]}]";
                case 3:
                    return $"[{a[0]}, {a[1]}, {a[2]}]";
                case 4:
                    return $"[{a[0]}, {a[1]}, {a[2]}, {a[3]}]";
                default:
                    if (a.Length < 10)
                        return $"[{a[0]}, {a[1]}, {a[2]},..., {a[a.Length - 1]}]";
                    return $"[{a[0]}, {a[1]}, {a[2]},..., {a[a.Length / 2]},..., {a[a.Length - 1]}]";
            }
        }

        public static int[] CreateRandom(int size, int? max = null, int? min = null)
        {
            if (size < 0) throw new ArgumentOutOfRangeException(nameof(size));
            var result = new int[size];
            var random = new Random();
            for (int i = 0; i < size; i++)
            {
                if (max.HasValue && min.HasValue)
                    result[i] = random.Next(min.Value, max.Value);
                else if (max.HasValue)
                    result[i] = random.Next(max.Value);
                else
                    result[i] = random.Next();
            }
            return result;
        }
    }
}
