using Algorithms.DwarfsRafting_Codility_Hard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DwarfsRafting_Codility_Hard_Tests
{
    [TestClass]
    public class Codility_Dwarfs_Hard_Tests
    {

        [TestMethod]
        public void SmallFullDwarfsRaft()
        {
            int size = 2;
            string barrels = "";
            string dwarfs = "1A 1B 2A 2B";

            int result = DwarfsRafting_Codility_Hard.ReturnNumberOfDwarfesThatCanFitOnTheRaft(size, barrels, dwarfs);

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void MaxSizeDraft()
        {
            int size = 26;
            string barrels = "25Z 21Z 23U 14Y 14Q 17R 16R 15X 21P 19Z 26S 15U 21S 24O";
            string dwarfs = "13C 9C 2D 5H 4M 12A 9J 3C 8C 12G 6I 2E 4K 6K 4H 8J 8H 6A 13E 5B 9B 4I 1B 6H 8K 10L 1M 8B 8L 7E 6J 2J 7A 5C 10I 11E 9G 10M 4C 2K 7J 11F 10A 4F 9E 1J 11M 9D 1C 13B 7D 9F 7F 7H 8M 6D 12L 3M 4D 7K 8D 5D 12J 13L 10E 6F 9M 6G 11G 12D 12C 9A 9K 6L 9L 5E 9H 1E 8A 6C 1F 10C 4L 2C 11J 5J 12H 1A 13J 5G 6E 7L 1I 11D 12K 5A 12B 5L 10J 13K 13M 11K 8I 2M 13G 4G 2H 1D 11I 4B 2A 10G 11C 13I 7M 7I 13F 11L 6B 10D 8G 3K 10F 5F 2G 7G 9I 3F 5I 1L 10B 6M 3I 13H 2I 8F 1G 2B 12F 3G 4E 1H 3J 3B 5K 1K 13D 2L 7C 8E 7B 10K 12M 11A 10H 3D 3A 12I 2F 3E 3H 11B 4J 5M 12E 11H 13A 4A 3L";
            
            int result = DwarfsRafting_Codility_Hard.ReturnNumberOfDwarfesThatCanFitOnTheRaft(size, barrels, dwarfs);

            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void EmptySmallRaft()
        {
            int size = 4;
            string barrels = "";
            string dwarfs = "";

            int result = DwarfsRafting_Codility_Hard.ReturnNumberOfDwarfesThatCanFitOnTheRaft(size, barrels, dwarfs);

            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void MaxSizeRaft()
        {
            int size = 26;
            string barrels = "";
            string dwarfs = "1D 10B 19G 13K 23H 1J 7R 4V 24Y 13X 20T 19Z 21J 2F 16U 12I 20E 19N 24H 1Y 10E 20W 15D 9B 6T 7U 9N 13Z 8M 11K 10F 17M 14Y 3Z 13L 6M 7C 17D 20A 17N 15N 15R 7J 14B 13C 11N 22I 22P 23U 18N 15J 15X 22T 25L 3Q 17W 13G 7T 7F 10R 7D 16N 19E 24O 8P 26T 12B 10Q 23O 9D 13H 3V 24F 18I 24A 13R 4F 9O 4K 7E 26A 7N 10V 7L 5Y 17S 21P 24D 9L 21Y 5J 20R 15E 16F 2X 4G 15K 23G 18L 9C 9J 13O 21R 13A 18C 10P 20F 5L 15A 14U 23Y 22Z 17P 15T 15G 20N 5X 4S 6H 12P 22W 10C 4T 17Y 10Z 18A 4Z 6V 20V 7Z 19R 10H 8O 2G 18P 4O 1S 10M 22B 5H 24T 2Y 21N 20X 18Z 11Q 13B 4B 13U 3M 14N 18E 17G 26J 16T 12K 19W 2T 20H 19B 8T 5R 24P 26M 1W 9S 12A 12Z 14L 8I 21Q 3F 9Z 14S 23N 6S 19M 12M 1X 6K 4I 23X 15C 7P 2J 6I 17A 20J 24K 7B 6J 2W 4X 6F 17B 18Y 15U 2L 17H 11D 23T 23J 3W 19J 14F 8N 1C 19U 5K 23A 19O 8Y 25T 21K 8H 13W 12E 25O 22Y 1N 23L 25P 16K 4L 26K 11X 1Q 15Z 5U 21L 1I 20Q 7Q 8C 11I 16D 3L 16Q 17Z 12S 19V 17C 6L 13N 11R 5W 14J 8J 7W 1U 23E 11J 23R 12N 2N 15M 22A 4J 17Q 26S 14G 5D 7V 15Y 17F 12V 6X 22L 1K 13V 7O 24B 11V 21X 16G 12L 4H 6W 16H 16Y 19L 9Y 9H 26H 21A 24L 14H 8U 3R 18M 11C 22N 25E 15I 14X 10T 12G 24J 23I 23K 10A 25H 5N 9P 17I 10N 19X 10J 22J 6D 2U 15O 11H 15V 5C 3E 6E 11Z 25C 6O 21M 12J 21B 19A 26N 15L 18G 21F 9R 13M 18X 12C 16Z 11E 13F 24I 22G 13S 12F 3K 3H 5I 9V 14E 6R 8K 14Q 6C 8G 20O 18V 4D 2V 17E 24M 1O 25Z 2A 23Z 2P 3G 21H 24E 20L 7A 18T 18R 8Q 18F 22C 4A 16P 4Q 2S 1M 25B 25U 4N 14T 17U 26E 19I 9T 12D 9X 2H 23S 6G 24G 22Q 24Z 12W 3X 26R 5E 6Q 16R 4R 16O 5M 17J 8F 18U 26W 15B 21U 20B 8A 4M 17X 1T 3I 5Q 1P 10K 5P 25W 13Y 3S 21E 25G 3A 10L 24V 2M 20G 26Q 23V 19S 7M 7H 26V 11S 13J 16W 21I 14M 8V 23W 3C 1R 2B 3D 11W 17R 4Y 23D 24N 19C 18D 19Q 4C 3Y 14C 10W 9M 23F 5S 6Y 23B 18B 12O 5B 11Y 7G 15P 20Z 6P 23Q 15H 8B 22S 9W 8Z 13E 3T 17L 22D 22V 18H 9G 15F 19H 1E 14O 22F 16L 21T 10Y 25S 14W 3O 12R 17V 10S 10U 20M 2C 3J 8L 16A 18O 26G 23C 4P 16X 23P 26L 20K 15Q 8D 1A 26C 12Y 21V 4E 12H 4W 8W 5F 16C 5G 20D 2I 24W 22O 13D 22E 2E 20S 26F 16B 11U 24X 1H 11A 14K 21D 8X 13T 25N 1Z 14A 18W 19D 26Z 2R 25R 22R 12U 26X 9K 2D 11T 11L 13I 16M 7Y";

            int result = DwarfsRafting_Codility_Hard.ReturnNumberOfDwarfesThatCanFitOnTheRaft(size, barrels, dwarfs);

            Assert.AreEqual(118, result);
        }

        [TestMethod]
        public void MediumRaft()
        {
            int size = 12;
            string barrels = "11C 10J 9C 8I 7D 1J 12I 2K";
            string dwarfs = "11D 4F 4B 3E 3J 7C 7G 1C 2C 2G 3I 9J 6G 11E 11G 2L 10L 12D 9A 10I 6J 8F 11I 12J 11A 5G 7J 3K 4E 4K";

            int result = DwarfsRafting_Codility_Hard.ReturnNumberOfDwarfesThatCanFitOnTheRaft(size, barrels, dwarfs);

            Assert.AreEqual(102, result);
        }
    }
}
