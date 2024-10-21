using MarsRoversControlV2.Abstractions;

namespace MarsRoversControlV2
{
    internal class MovingOneStep
    {
        private Detector detector1 = new IsExitBeyondThePlateau();
        private Detector detector2 = new IsAnotherMarsRoverOnTheWay();
        
        internal void MovingTheMarsRoverOneStep(MotionController motionController)
        {
            switch (motionController.MarsRoverDirection)
            {
                case 'N':
                    if (!detector1.Сheck(motionController, 'N') && !detector2.Сheck(motionController,'N'))
                        motionController.PositionY += 1;
                    break;
                case 'S':
                    if (!detector1.Сheck(motionController,'S') && !detector2.Сheck(motionController,'S'))
                        motionController.PositionY -= 1;
                    break;
                case 'E':
                    if (!detector1.Сheck(motionController,'E') && !detector2.Сheck(motionController,'E'))
                        motionController.PositionX += 1;
                    break;
                case 'W':
                    if (!detector1.Сheck(motionController,'W') && !detector2.Сheck(motionController,'W'))
                        motionController.PositionX -= 1;
                    break;
            }
        }
    }
}
