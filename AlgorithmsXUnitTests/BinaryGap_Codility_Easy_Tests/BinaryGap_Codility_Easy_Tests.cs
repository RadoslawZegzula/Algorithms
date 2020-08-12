using Algorithms.BinaryGap_Codility_Easy;
using Xunit;

namespace AlgorithmsXUnitTests.BinaryGap_Codility_Easy_Tests
{
    public class BinaryGap_Codility_Easy_Tests
    {
        [Theory]
        [InlineData(1041, 5)]
        [InlineData(15, 0)]
        [InlineData(32, 0)]
        public void ExampleTests(int n, int expected)
        {
            int result = BinaryGap_Codility_Easy.FindLongestSequenceOfBinaryZeros(n);

            Assert.Equal(expected, result);
        }

    }
}
