using Algorithms.PermMissingElem_Codility_Easy;
using Xunit;

namespace AlgorithmsXUnitTests.PermMissingElem_Codility_Easy_Tests
{
    public class PermMissingElem_Codility_Easy_Tests
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 1, 5 }, 4)]
        public void ExampleTests(int[] array, int expected)
        {
            int result = PermMissingElem_Codility_Easy.ReturnMissingElement(array);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 6)]
        [InlineData(new int[] { 2, 3, 4, 5, 6 }, 1)]
        public void MissingFirstOrLast(int[] array, int expected)
        {
            int result = PermMissingElem_Codility_Easy.ReturnMissingElement(array);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { }, 1)]
        [InlineData(new int[] { 1 }, 2)]
        [InlineData(new int[] { 2 }, 1)]
        [InlineData(new int[] { 3 }, 1)]
        [InlineData(new int[] { 4 }, 1)]
        [InlineData(new int[] { 5 }, 1)]
        [InlineData(new int[] { 6 }, 1)]
        [InlineData(new int[] { 7 }, 1)]
        [InlineData(new int[] { 8 }, 1)]
        [InlineData(new int[] { 9 }, 1)]
        [InlineData(new int[] { 10 }, 1)]
        public void SingleOrEmpty(int[] array, int expected)
        {
            int result = PermMissingElem_Codility_Easy.ReturnMissingElement(array);

            Assert.Equal(expected, result);
        }

    }
}
