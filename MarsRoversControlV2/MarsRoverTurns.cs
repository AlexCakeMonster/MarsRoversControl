using MarsRoversControlV2.Abstractions;

namespace MarsRoversControlV2
{
    internal class MarsRoverTurns : MarsRoverStatus
    {
        public override void Action(MotionController motionController, char direction)
        {
            switch (motionController.MarsRoverDirection)
            {
                case 'N':
                    motionController.MarsRoverDirection = direction == 'L' ? 'W' : 'E';
                    break;
                case 'S':
                    motionController.MarsRoverDirection = direction == 'L' ? 'E' : 'W';
                    break;
                case 'E':
                    motionController.MarsRoverDirection = direction == 'L' ? 'N' : 'S';
                    break;
                case 'W':
                    motionController.MarsRoverDirection = direction == 'L' ? 'S' : 'N';
                    break;
            }
        }
    }
}
