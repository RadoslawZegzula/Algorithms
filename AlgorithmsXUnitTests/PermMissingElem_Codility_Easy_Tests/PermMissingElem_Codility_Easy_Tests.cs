﻿using Algorithms.PermMissingElem_Codility_Easy;
using Xunit;

namespace AlgorithmsXUnitTests.PermMissingElem_Codility_Easy_Tests
{
    public class PermMissingElem_Codility_Easy_Tests
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 1, 5 }, 4)]
        public void ExampleTests(int[] x, int expected)
        {
            int result = PermMissingElem_Codility_Easy.ReturnMissingElement(x);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 6)]
        [InlineData(new int[] { 2, 3, 4, 5, 6 }, 1)]
        public void missing_first_or_last(int[] x, int expected)
        {
            int result = PermMissingElem_Codility_Easy.ReturnMissingElement(x);

            Assert.Equal(expected, result);
        }

    }
}
