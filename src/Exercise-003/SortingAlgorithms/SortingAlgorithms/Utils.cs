using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public static class Utils
    {
        public static string ToShortText<T>(this T[] a)
        {
            switch (a?.Length)
            {
                case null:
                    return "NULL";
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

        public static int[] CreateRandomArray(int size, int? max = null, int? min = null)
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

        public static void Move<T>(this IList<T> a, int oldIndex, int newIndex)
        {
            var removed = a[oldIndex];
            a.RemoveAt(oldIndex);
            a.Insert(newIndex, removed);
        }
    }
}
