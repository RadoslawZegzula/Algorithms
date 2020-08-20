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
        [InlineData(new int[] { 1, 2 }, 3)]
        [InlineData(new int[] { 3, 1 }, 2)]
        [InlineData(new int[] { 3, 2 }, 1)]
        public void TwoElements(int[] x, int expected)
        {
            int result = PermMissingElem_Codility_Easy.ReturnMissingElement(x);

            Assert.Equal(expected, result);
        }
    }
}