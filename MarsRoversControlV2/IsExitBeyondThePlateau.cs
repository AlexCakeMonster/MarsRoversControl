using MarsRoversControlV2.Abstractions;

namespace MarsRoversControlV2
{
    internal class IsExitBeyondThePlateau : Detector
    {
        public override bool Сheck(MotionController motionController, char direction)
        {
            switch (direction)
            {
                case 'N':
                    return motionController.PositionY + 1 > motionController.Plateau.UpperOfThePlateauY;
                case 'S':
                    return motionController.PositionY - 1 < 0;
                case 'E':
                    return motionController.PositionX + 1 > motionController.Plateau.UpperOfThePlateauX;
                case 'W':
                    return motionController.PositionX - 1 < 0;
                default:
                    return true;
            }
        }
    }
}
