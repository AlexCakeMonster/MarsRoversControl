using MarsRoversControlV2;
using MarsRoversControlV2.Abstractions;

namespace MarsRoversControlV2Tests
{
    [TestClass]
    public class MarsRoverTurnsTests
    {
        private readonly Plateau plateau = new("5 5");
        private MotionController controller;
        private MarsRoverStatus turn = new MarsRoverTurns();

        [TestMethod]
        public void Action_MotionControllerAndDirection_NewDirection()
        {
            (char direction, char newDirection, char command)[] testData =
            [
                ('W', 'S', 'L'),
                ('W', 'N', 'R'),
                ('N', 'W', 'L'),
                ('N', 'E', 'R'),
                ('S', 'E', 'L'),
                ('S', 'W', 'R'),
                ('E', 'N', 'L'),
                ('E', 'S', 'R')
            ];

            controller = new MarsRoverMotionController
            {
                PositionX = 2,
                PositionY = 2,
                Plateau = plateau
            };

            foreach (var item in testData)
            {
                controller.MarsRoverDirection = item.direction;
                turn.Action(controller, item.command);
                char expected = item.newDirection;
                Assert.AreEqual(controller.MarsRoverDirection, expected);
            }
        }
    }
}
