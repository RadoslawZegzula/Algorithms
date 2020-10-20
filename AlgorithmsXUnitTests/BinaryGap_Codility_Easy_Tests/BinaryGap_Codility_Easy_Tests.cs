using Algorithms.BinaryGap_Codility_Easy;
using Xunit;

namespace AlgorithmsXUnitTests.BinaryGap_Codility_Easy_Tests
{
    public class BinaryGap_Codility_Easy_Tests
    {

        /// <summary>
        /// 1041 == 10000010001
        /// 15 == 1111
        /// 32 == 100000
        /// 10241 == 10100000000001
        /// </summary>
        [Theory]
        [InlineData(1041, 5)]
        [InlineData(15, 0)]
        [InlineData(32, 0)]
        [InlineData(10241, 10)]
        public void ExampleTests(int number, int expected)
        {
            int result = BinaryGap_Codility_Easy.FindLongestSequenceOfBinaryZeros(number);

            Assert.Equal(expected, result);
        }

        /// <summary>
        /// 6 == 110
        /// 328 == 101001000
        /// 1224 == 10011001000
        /// 7168 == 1110000000000
        /// </summary>
        [Theory]
        [InlineData(6, 0)]
        [InlineData(328, 2)]
        [InlineData(1224, 2)]
        [InlineData(7168, 0)]
        public void shouldWorkWith_TrailingZeros(int number, int expected)
        {
            int result = BinaryGap_Codility_Easy.FindLongestSequenceOfBinaryZeros(number);

            Assert.Equal(expected, result);
        }

        /// <summary>
        /// 6291457 = 11000000000000000000001
        /// 74901729 = 100011101101110100011100001
        /// 805306373 = 110000000000000000000000000101
        /// 999999999 = 111011100110101100100111111111
        /// </summary>
        [Theory]
        [InlineData(6291457, 20)]
        [InlineData(74901729, 4)]
        [InlineData(805306373, 25)]
        [InlineData(999999999, 2)]
        public void LargeNumbers(int number, int expected)
        {
            int result = BinaryGap_Codility_Easy.FindLongestSequenceOfBinaryZeros(number);

            Assert.Equal(expected, result);
        }

    }
}
