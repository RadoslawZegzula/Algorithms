using Algorithms.FrogJmp_Codility_Easy;
using Xunit;

namespace AlgorithmsXUnitTests.FrogJmp_Codility_Easy_Tests
{
    public class FrogJmp_Codility_Easy_Tests
    {
        [Theory]
        [InlineData(10, 85, 30, 3)]
        public void ExampleTests(int x, int y, int d, int expected)
        {
            int result = FrogJmp_Codility_Easy.CountMinimalNumberOfJumpsFromXToY(x, y, d);

            Assert.Equal(expected, result);
        }
    }
}
