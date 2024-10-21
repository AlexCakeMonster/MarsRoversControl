using MarsRoversControlV2.Abstractions;

namespace MarsRoversControlV2
{
    internal class IsAnotherMarsRoverOnTheWay : Detector
    {
        public override bool Сheck(MotionController motionController, char direction)
        {

            foreach (var item in motionController.MarsRovers)
            {
                if (item.motionController != motionController)
                {
                    string[] coordinates = item.MarsRoverPosition.Split(" ");
                    switch (direction)
                    {
                        case 'N':
                            if (int.Parse(coordinates[0]) == motionController.PositionX &&
                                (int.Parse(coordinates[1]) == motionController.PositionY + 1) == true)
                            {
                                return true;
                            }
                            break;
                        case 'S':
                            if (int.Parse(coordinates[0]) == motionController.PositionX &&
                                  (int.Parse(coordinates[1]) == motionController.PositionY - 1) == true)
                            {
                                return true;
                            }
                            break;
                        case 'E':
                            if (int.Parse(coordinates[1]) == motionController.PositionY &&
                                (int.Parse(coordinates[0]) == motionController.PositionX + 1) == true)
                            {
                                return true;
                            }
                            break;
                        case 'W':
                            if (int.Parse(coordinates[1]) == motionController.PositionY &&
                                (int.Parse(coordinates[0]) == motionController.PositionX - 1) == true)
                            {
                                return true;
                            }
                            break;

                    }
                }

            }
            return false;
        }
    }
}
