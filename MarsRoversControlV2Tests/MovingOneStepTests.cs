using MarsRoversControlV2.Abstractions;
using MarsRoversControlV2;

namespace MarsRoversControlV2Tests
{
    [TestClass]
    public class MovingOneStepTests
    {
        private Plateaus plateau = new Plateau("5 5");
        private List<MarsRover> marsRovers = [new MarsRover() { MarsRoverPosition = "3 3 E" }];
        private MovingOneStep moving = new MovingOneStep();

        [TestMethod]
        public void MovingTheMarsRoverOneStep_DirectionN_MoveMarsRoverCell()
        {
            var controller = new MarsRoverMotionController
            {
                PositionX = 2,
                PositionY = 2,
                MarsRoverDirection = 'N',
                Plateau = plateau,
                MarsRovers = marsRovers
            };
            moving.MovingTheMarsRoverOneStep(controller);
            int expected = 3;
            Assert.AreEqual(controller.PositionY, expected);
        }

        [TestMethod]
        public void MovingTheMarsRoverOneStep_DirectionS_MoveMarsRoverCell()
        {
            var controller = new MarsRoverMotionController
            {
                PositionX = 2,
                PositionY = 2,
                MarsRoverDirection = 'S',
                Plateau = plateau,
                MarsRovers = marsRovers
            };
            moving.MovingTheMarsRoverOneStep(controller);
            int expected = 1;
            Assert.AreEqual(controller.PositionY, expected);
        }

        [TestMethod]
        public void MovingTheMarsRoverOneStep_DirectionE_MoveMarsRoverCell()
        {
            var controller = new MarsRoverMotionController
            {
                PositionX = 2,
                PositionY = 2,
                MarsRoverDirection = 'E',
                Plateau = plateau,
                MarsRovers = marsRovers
            };
            moving.MovingTheMarsRoverOneStep(controller);
            int expected = 3;
            Assert.AreEqual(controller.PositionX, expected);
        }

        [TestMethod]
        public void MovingTheMarsRoverOneStep_DirectionW_MoveMarsRoverCell()
        {
            var controller = new MarsRoverMotionController
            {
                PositionX = 2,
                PositionY = 2,
                MarsRoverDirection = 'W',
                Plateau = plateau,
                MarsRovers = marsRovers
            };
            moving.MovingTheMarsRoverOneStep(controller);
            int expected = 1;
            Assert.AreEqual(controller.PositionX, expected);
        }
    }
}
