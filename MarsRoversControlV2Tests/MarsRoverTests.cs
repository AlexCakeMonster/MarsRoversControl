using MarsRoversControlV2;
using MarsRoversControlV2.Abstractions;

namespace MarsRoversControlV2Tests
{
    [TestClass]
    public class MarsRoverTests
    {
        [TestMethod]
        public void Move()
        {
            List<MarsRover> marsRovers = [new MarsRover() { MarsRoverPosition = "3 3 E" }];
            Plateaus plateau = new Plateau("5 5");
            var controller = new MarsRoverMotionController
            {
                PositionX = 1,
                PositionY = 2,
                MarsRoverDirection = 'N',
                Plateau = plateau,
                MarsRovers = marsRovers
            };
            var marsRover = new MarsRover("1 2 N", "LMLMLMLMM", controller);
            const string expected = "1 3 N";
            Assert.AreEqual(marsRover.Move(), expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MarsRover_UnfaithfulStringStartingCoordinates_Exception()
        {
            var controller = new MarsRover("1 D N", "LMLMLMLMM", new MarsRoverMotionController());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MarsRover_UnfaithfulStringInstructionsForMoving_Exception()
        {
            var controller = new MarsRover("1 3 N", "LMLM5MLMM", new MarsRoverMotionController());
        }
    }
}
