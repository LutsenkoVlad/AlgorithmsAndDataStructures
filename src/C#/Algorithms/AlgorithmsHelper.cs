using System.Collections.Generic;

namespace Algorithms
{
    public static class AlgorithmsHelper
    {
        public static void Swap<T>(IList<T> arr, int left, int right)
        {
            var temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }
    }
}
