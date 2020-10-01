using Algorithms.OddOccurrencesInArray_Codility_Easy.SecondSolution_BetterPerformance;
using Xunit;

namespace AlgorithmsXUnitTests.OddOccurrencesInArray_Codility_Easy_Tests.SecondSolution_BetterPerformance_Tests
{
    public class Codility_OddOccurrencesInArray_Easy_BetterPerformance_Tests
    {
        [Theory]
        [InlineData(new int[] { 9, 3, 9, 3, 9, 7, 9 }, 7)]
        public void ExampleTest(int[] array, int expected)
        {
            int result = Codility_OddOccurrencesInArray_Easy_BetterPerformance.FindOddOccurrenceInArray(array);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 9 }, 9)]
        [InlineData(new int[] { 42 }, 42)]
        [InlineData(new int[] { 33 }, 33)]
        public void SingleElement(int[] arr, int expected)
        {
            int result = Codility_OddOccurrencesInArray_Easy_BetterPerformance.FindOddOccurrenceInArray(arr);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 9, 9, 1 }, 1)]
        [InlineData(new int[] { 9, 1 ,9 }, 1)]
        [InlineData(new int[] { 1, 9, 9 }, 1)]
        public void ThreeElements(int[] arr, int expected)
        {
            int result = Codility_OddOccurrencesInArray_Easy_BetterPerformance.FindOddOccurrenceInArray(arr);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 91, 69, 77, 91, 26, 64, 91, 88, 58, 17, 42 }, 17)]
        [InlineData(new int[] { 17, 69, 64, 48, 22, 80, 81, 52, 51, 24, 1, 38, 59, 7, 80, 24, 24, 5, 100, 74, 88, 62, 4, 33, 50, 12, 96, 37, 16, 82, 13, 93, 46, 56, 35, 49, 19, 4, 87, 24, 79, 21, 97, 90, 76, 77, 59, 73, 13, 48, 83, 21, 93, 89, 41, 37, 46, 39, 100, 39, 3, 10, 72, 100, 50, 50, 56, 75, 23, 61, 56, 63, 19, 18, 35, 93, 35, 60, 31, 11, 7, 82, 78, 38, 69, 68, 90, 96, 41, 99, 97, 60, 89, 50, 38, 25, 88, 17, 7, 81, 4242}, 1)]
        public void SmallTest(int[] arr, int expected)
        {
            int result = Codility_OddOccurrencesInArray_Easy_BetterPerformance.FindOddOccurrenceInArray(arr);

            Assert.Equal(expected, result);
        }

    }
}
