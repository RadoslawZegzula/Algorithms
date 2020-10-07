using Algorithms.OddOccurrencesInArray_Codility_Easy.FirstSolution_SlowPerformance;
using Xunit;

namespace AlgorithmsXUnitTests.OddOccurrencesInArray_Codility_Easy_Tests.FirstSolution_SlowPerformance_Tests
{
    public class Codility_OddOccurrencesInArray_Easy_SlowPerformance_Tests
    {
        [Theory]
        [InlineData(new int[] { 9, 3, 9, 3, 9, 7, 9}, 7)]
        public void ExampleTest(int[] array, int expected)
        {
            int result = Codility_OddOccurrencesInArray_Easy_SlowPerformance.FindOddOccurrenceInArray(array);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 9 }, 9)]
        [InlineData(new int[] { 42 }, 42)]
        [InlineData(new int[] { 33 }, 33)]
        public void SingleElement(int[] array, int expected)
        {
            int result = Codility_OddOccurrencesInArray_Easy_SlowPerformance.FindOddOccurrenceInArray(array);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 9, 9, 1 }, 1)]
        [InlineData(new int[] { 9, 1, 9 }, 1)]
        [InlineData(new int[] { 1, 9, 9 }, 1)]
        public void ThreeElements(int[] array, int expected)
        {
            int result = Codility_OddOccurrencesInArray_Easy_SlowPerformance.FindOddOccurrenceInArray(array);

            Assert.Equal(expected, result);
        }

    }
}
