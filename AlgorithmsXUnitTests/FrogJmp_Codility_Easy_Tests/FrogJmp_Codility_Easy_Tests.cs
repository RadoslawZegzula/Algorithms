using Algorithms.FrogJmp_Codility_Easy;
using Xunit;

namespace AlgorithmsXUnitTests.FrogJmp_Codility_Easy_Tests
{
    public class FrogJmp_Codility_Easy_Tests
    {
        [Theory]
        [InlineData(10, 85, 30, 3)]
        [InlineData(0, 91, 30, 4)]
        [InlineData(10, 85, 90, 1)]
        public void ExampleTests(int startingPosition, int endingPosition, int jumpDistance, int expected)
        {
            int result = FrogJmp_Codility_Easy.CountMinimalNumberOfJumpsFromXToY(startingPosition, endingPosition, jumpDistance);

            Assert.Equal(expected, result);
        }
    }
}
