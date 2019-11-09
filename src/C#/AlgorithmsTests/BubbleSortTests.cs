using Algorithms;
using Xunit;

namespace AlgorithmsTests
{
    public class BubbleSortTests
    {
        [Fact]
        public void BubbleSort_ShouldSortCorrectly()
        {
            int[] arr = { 3, 7, 4, 4, 6, 5, 8 };

            BubbleSort.Sort(arr);

            Assert.Equal(3, arr[0]);
            Assert.Equal(4, arr[1]);
            Assert.Equal(4, arr[2]);
            Assert.Equal(5, arr[3]);
            Assert.Equal(6, arr[4]);
            Assert.Equal(7, arr[5]);
            Assert.Equal(8, arr[6]);
            Assert.Equal(7, arr.Length);
        }
    }
}
