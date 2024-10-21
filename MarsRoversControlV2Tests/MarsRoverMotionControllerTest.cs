using MarsRoversControlV2;

namespace MarsRoversControlV2Tests
{
    [TestClass]
    public class MarsRoverMotionControllerTest
    {
        private readonly Plateau plateau = new("5 5");
        List<MarsRover> marsRovers = [new MarsRover() { MarsRoverPosition = "3 3 E" }];
        

        [TestMethod]
        public void ExtractingCoordinates_StringStartingCoordinates_XYDirection()
        {
            var controller = new MarsRoverMotionController();
            controller.ExtractingCoordinates("1 2 S");
            int coordinateX = 1;
            int coordinateY = 2;
            char direction = 'S';

            Assert.AreEqual(controller.PositionX, coordinateX);
            Assert.AreEqual(controller.PositionY, coordinateY);
            Assert.AreEqual(controller.MarsRoverDirection, direction);
        }

        [TestMethod]
        public void MovingTheMarsRover_StringInstructions_StringNewCoordinatesAndDirection()
        {
            var controller = new MarsRoverMotionController
            {
                PositionX = 1,
                PositionY = 2,
                MarsRoverDirection = 'N',
                Plateau = plateau,
                MarsRovers = marsRovers
            };
            string expected = "1 3 N";
            Assert.AreEqual(expected, controller.MovingTheMarsRover("LMLMLMLMM"));
        }
    }
}
