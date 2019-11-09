using System;
using System.Collections.Generic;

namespace Algorithms
{
    public static class BubbleSort
    {
        public static void Sort<T>(IList<T> arr) where T : IComparable<T>
        {
            bool swapped = false;
            for (var i = 0; i < arr.Count - 1; i++)
            {
                for (var j = 0; j < arr.Count - 1 - i; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        AlgorithmsHelper.Swap(arr, j, j + 1);
                        swapped = true;
                    }
                }

                if (!swapped) break;
            }
        }
    }
}
