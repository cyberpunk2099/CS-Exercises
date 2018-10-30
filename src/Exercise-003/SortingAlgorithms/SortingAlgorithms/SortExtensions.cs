using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public static class SortExtensions
    {
        /// <summary Selection Sort />
        /// <seealso cref="https://www.youtube.com/watch?v=NEbb4XqKDNU"/>
        public static void SelectionSort<T>(this T[] a) where T : IComparable
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

        /// <summary Bubble Sort />
        /// <seealso cref="https://www.youtube.com/watch?v=LZaU8GHNsQI"/>
        public static void BubbleSort<T>(this T[] a) where T : IComparable
        {
            if (a == null || a.Length <= 1) return;
            var swapped = -1;
            var len = a.Length;
            while (swapped != 0)
            {
                len--;
                swapped = 0;
                for (int i = 0; i < len; i++)
                {
                    if (a[i].CompareTo(a[i + 1]) < 0) continue;
                    (a[i], a[i + 1]) = (a[i + 1], a[i]);
                    swapped++;
                }
            }
        }
        
        /// <summary Insertion Sort />
        /// <seealso cref="https://www.youtube.com/watch?v=ntB1D3Bbz5I"/>
        public static void InsertionSort<T>(this IList<T> a) where T : IComparable
        {
            if (a == null || a.Count <= 1) return;
            for (int i = 0; ++i < a.Count;)
                for (int j = i; --j >= 0;)
                {
                    if (a[j].CompareTo(a[j + 1]) <= 0) break;
                    a.Move(j + 1, j);
                }
        }
    }
}
