using MarsRoversControlV2;
using MarsRoversControlV2.Abstractions;

namespace MarsRoversControlV2Tests
{
    [TestClass]
    public class IsExitBeyondThePlateauTests
    {
        private readonly Plateau plateau = new("5 5");
        private readonly Detector detector = new IsExitBeyondThePlateau();
        [TestMethod]
        public void Check_MarsRoverDirection_False()
        {
            var controller = new MarsRoverMotionController
            {
                PositionX = 1,
                PositionY = 1,
                Plateau = plateau
            };
            Assert.IsFalse(detector.Сheck(controller,'N'));
        }
        [TestMethod]
        public void Check_MarsRoverDirection_True()
        {
            var controller = new MarsRoverMotionController
            {
                PositionX = 5,
                PositionY = 5,
                Plateau = plateau
            };
            Assert.IsTrue(detector.Сheck(controller, 'N'));
        }
    }
}
