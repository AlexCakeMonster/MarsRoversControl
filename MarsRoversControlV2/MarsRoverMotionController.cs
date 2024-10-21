using MarsRoversControlV2.Abstractions;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MarsRoversControlV2Tests")]

namespace MarsRoversControlV2
{
    internal class MarsRoverMotionController : MotionController
    {
        private readonly MarsRoverStatus turn = new MarsRoverTurns();
        private readonly MarsRoverStatus movement = new MarsRoverMoves();
        internal MarsRoverMotionController()
        {

        }
        internal MarsRoverMotionController(string coordinatesAndDirection, Plateaus plateau, List<MarsRover> marsRovers)
        {
            ExtractingCoordinates(coordinatesAndDirection);
            Plateau = plateau;
            MarsRovers = marsRovers;
        }

        internal override string MovingTheMarsRover(string instructionsForMoving)
        {
            foreach (var item in instructionsForMoving)
            {
                if (item == 'M')
                {
                    movement.Action(this,item);
                }
                else
                {
                    turn.Action(this, item);
                }
            }
            return $"{PositionX} {PositionY} {MarsRoverDirection}";
        }

        internal void ExtractingCoordinates(string CoordinatesAndDirection)
        {
            string[] coordinates = CoordinatesAndDirection.Split(" ");
            PositionX = int.Parse(coordinates[0]);
            PositionY = int.Parse(coordinates[1]);
            MarsRoverDirection = Convert.ToChar(coordinates[2]);
        }
    }
}
