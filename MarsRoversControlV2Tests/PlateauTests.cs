using MarsRoversControlV2;

namespace MarsRoversControlV2Tests
{
    [TestClass]
    public class PlateauTests
    {
        [TestMethod]
        public void ExtractingCoordinates_StringCoordinates_CoordinatesXY()
        {
            var plateau = new Plateau("5 4");
            const int expectedX = 5;
            const int expectedY = 4;
            Assert.AreEqual(expectedX, plateau.UpperOfThePlateauX);
            Assert.AreEqual(expectedY, plateau.UpperOfThePlateauY);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExtractingCoordinates_StringCoordinates_Exception()
        {
            var plateau = new Plateau("5 а");
        }
    }
}
