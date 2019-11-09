using DataStructures;
using System;
using Xunit;

namespace SingleLinkedListUnitTests
{
    public class SingleLinkedListTests
    {
        [Fact]
        public void InsertAfter_ShouldReturnTrue_IfValueIsFoundAfterWhichItShouldBeInserted()
        {
            var list = new SingleLinkedList<int>(15);

            bool operationResult = list.InsertAfter(15, 25);

            Assert.True(operationResult);
        }

        [Fact]
        public void InsertAfter_ShouldReturnFalse_IfValueIsNotFoundAfterWhichItShouldBeInserted()
        {
            var list = new SingleLinkedList<int>(15);

            bool operationResult = list.InsertAfter(15, 25);

            Assert.True(operationResult);
        }

        [Fact]
        public void Remove_ShouldReturnFalse_IfListIsEmpty()
        {
            var list = new SingleLinkedList<DateTime>();

            var operationResult = list.Remove(new DateTime(2019, 10, 18));

            Assert.False(operationResult);
        }

        [Fact]
        public void Remove_ShouldToDoListEmpty_IfListHasOneItem()
        {
            var date = new DateTime(2019, 10, 18);
            var list = new SingleLinkedList<DateTime>(date);

            var isEmpty = list.Remove(date);

            Assert.True(isEmpty);
        }

        [Fact]
        public void Remove_ShouldDecreaseCountByOne_IfValueWasFound()
        {
            int[] array1 = { 2123, 2312, 23123 };
            int[] array2 = { 21645645, 6463, 23123324 };
            int[] array3 = { 2645, 9993, 4, 123, 123 };
            var list = new SingleLinkedList<int[]>();

            list.Push(array1);
            list.Push(array2);
            list.Push(array3);
            int expected = list.Count - 1;
            list.Remove(array1);

            Assert.Equal(expected, list.Count);
        }

        [Fact]
        public void Remove_ItemWhichIsHeadInList_ShouldNot()
        {
            int[] array1 = { 2123, 2312, 23123 };
            int[] array2 = { 21645645, 6463, 23123324 };
            int[] array3 = { 2645, 9993, 4, 123, 123 };
            var list = new SingleLinkedList<int[]>();

            list.Push(array1);
            list.Push(array2);
            list.Push(array3);
            int expected = list.Count - 1;
            list.Remove(array1);

            Assert.Equal(expected, list.Count);
        }

        [Theory]
        [InlineData(7, "123", "21312", "12313", "123123", "213123", "123123", "123123")]
        [InlineData(1, "123")]
        [InlineData(0)]
        public void ForEach_ShouldReturnAllValuesInList(
            int expected,
            params string[] values)
        {
            var list = new SingleLinkedList<string>();
            int count = 0;

            foreach (var value in values) list.Push(value);
            foreach (var value in list) count++;

            Assert.Equal(expected, count);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(4, "first", "second", "third", "fouth")]
        [InlineData(1, "first")]
        [InlineData(16, "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16")]
        public void Push_CountOfNumber_ShouldBeCountOfPushedNumbers(
            int expected,
            params string[] values)
        {
            var list = new SingleLinkedList<string>();

            foreach (var value in values) list.Push(value);

            Assert.Equal(expected, list.Count);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(4, "first", "second", "third", "fouth")]
        [InlineData(1, "first")]
        [InlineData(16, "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16")]
        public void Append_CountOfNumber_ShouldBeCountOfAppendNumbers(
            int expected,
            params string[] values)
        {
            var list = new SingleLinkedList<string>();

            foreach (var value in values) list.Append(value);

            Assert.Equal(expected, list.Count);
        }
    }
}
