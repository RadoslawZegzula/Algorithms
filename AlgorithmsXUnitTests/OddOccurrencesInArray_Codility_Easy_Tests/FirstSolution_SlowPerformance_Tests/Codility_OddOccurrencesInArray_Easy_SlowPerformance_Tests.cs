using Algorithms.OddOccurrencesInArray_Codility_Easy.FirstSolution_SlowPerformance;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmsXUnitTests.OddOccurrencesInArray_Codility_Easy_Tests.FirstSolution_SlowPerformance_Tests
{
    public class Codility_OddOccurrencesInArray_Easy_SlowPerformance_Tests
    {
        [Theory]
        [InlineData(new int[] { 9, 3, 9, 3, 9, 7, 9}, 7)]
        public void ExampleTest(int[] arr, int expected)
        {
            int result = Codility_OddOccurrencesInArray_Easy_SlowPerformance.Solution(arr);

            Assert.Equal(expected, result);
        }
    }
}
