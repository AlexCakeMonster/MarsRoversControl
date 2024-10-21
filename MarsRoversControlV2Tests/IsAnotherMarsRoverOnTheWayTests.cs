using MarsRoversControlV2;
using MarsRoversControlV2.Abstractions;

namespace MarsRoversControlV2Tests
{
    [TestClass]
    public class IsAnotherMarsRoverOnTheWayTests
    {
        private readonly Plateau plateau = new("5 5");
        List<MarsRover> marsRovers = [new MarsRover() { MarsRoverPosition = "3 3 E" }];
        private Detector detector = new IsAnotherMarsRoverOnTheWay();
        [TestMethod]
        public void Check_MarsRoverDirection_False()
        {
            var controller = new MarsRoverMotionController
            {
                PositionX = 1,
                PositionY = 2,
                MarsRoverDirection = 'N',
                Plateau = plateau,
                MarsRovers = marsRovers
            };
            Assert.IsFalse(detector.Сheck(controller,'N'));
        }

        [TestMethod]
        public void Check_MarsRoverDirection_True()
        {
            var controller = new MarsRoverMotionController
            {
                PositionX = 3,
                PositionY = 2,
                MarsRoverDirection = 'N',
                Plateau = plateau,
                MarsRovers = marsRovers
            };
            Assert.IsTrue(detector.Сheck(controller, 'N'));
        }
    }
}

