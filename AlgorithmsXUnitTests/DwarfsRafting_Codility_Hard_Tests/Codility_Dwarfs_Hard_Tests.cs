
using Algorithms.DwarfsRafting_Codility_Hard;
using Xunit;

namespace AlgorithmsXUnitTests.DwarfsRafting_Codility_Hard_Tests
{  
    public class Codility_Dwarfs_Hard_Tests
    {
        [Theory]
        [InlineData(4, "1B 1C 4B 1D 2A", "3B 2D", 6)]
        [InlineData(2, "", "", 4)]
        [InlineData(4, "", "", 16)]
        public void SmallRaft(int size, string barrels, string dwarfs, int expected)
        {
            int result = DwarfsRafting_Codility_Hard.ReturnNumberOfDwarfesThatCanFitOnTheRaft(size, barrels, dwarfs);
            
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, "","", 0)]
        public void SizeZeroRaft(int size, string barrels, string dwarfs, int expected)
        {
            int result = DwarfsRafting_Codility_Hard.ReturnNumberOfDwarfesThatCanFitOnTheRaft(size, barrels, dwarfs);

            Assert.Equal(expected, result);
        }

    }
}
