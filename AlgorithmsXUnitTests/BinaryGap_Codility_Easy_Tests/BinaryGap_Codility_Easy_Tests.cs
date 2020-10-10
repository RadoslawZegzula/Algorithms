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
        public void ExampleTests(int number, int expected)
        {
            int result = BinaryGap_Codility_Easy.FindLongestSequenceOfBinaryZeros(number);

            Assert.Equal(expected, result);
        }

        /// <summary>
        /// 6 == 110
        /// 328 == 101001000
        /// </summary>
        [Theory]
        [InlineData(6, 0)]
        [InlineData(328, 2)]
        public void TrailingZeros(int number, int expected)
        {
            int result = BinaryGap_Codility_Easy.FindLongestSequenceOfBinaryZeros(number);

            Assert.Equal(expected, result);
        }

        /// <summary>
        /// 6291457 = 11000000000000000000001
        /// 74901729 = 100011101101110100011100001
        /// 805306373 = 110000000000000000000000000101
        /// </summary>
        [Theory]
        [InlineData(6291457, 20)]
        [InlineData(74901729, 4)]
        [InlineData(805306373, 25)]
        public void LargeNumbers(int number, int expected)
        {
            int result = BinaryGap_Codility_Easy.FindLongestSequenceOfBinaryZeros(number);

            Assert.Equal(expected, result);
        }

    }
}
