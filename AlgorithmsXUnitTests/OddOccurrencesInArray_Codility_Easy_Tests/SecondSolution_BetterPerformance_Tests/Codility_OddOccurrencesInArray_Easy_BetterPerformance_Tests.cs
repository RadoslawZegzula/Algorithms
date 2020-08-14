using Algorithms.OddOccurrencesInArray_Codility_Easy.SecondSolution_BetterPerformance;
using Xunit;

namespace AlgorithmsXUnitTests.OddOccurrencesInArray_Codility_Easy_Tests.SecondSolution_BetterPerformance_Tests
{
    public class Codility_OddOccurrencesInArray_Easy_BetterPerformance_Tests
    {
        [Theory]
        [InlineData(new int[] { 9, 3, 9, 3, 9, 7, 9 }, 7)]
        public void ExampleTest(int[] arr, int expected)
        {
            int result = Codility_OddOccurrencesInArray_Easy_BetterPerformance.Solution(arr);

            Assert.Equal(expected, result);
        }
    }
}
