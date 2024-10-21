using MarsRoversControlV2.Abstractions;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MarsRoversControlV2Tests")]

namespace MarsRoversControlV2
{
    internal class MarsRover
    {
        internal string MarsRoverPosition { get; set; }
        private string InstructionsForMoving { get; }
        internal MotionController motionController;
        internal bool isTheMarsRoverMoving;

        internal MarsRover()
        {

        }
        internal MarsRover(string startingCoordinatesAndDirection, string instructionsForMoving, MotionController motionController)
        {
            if (CommandPatterns._patternStartingCoordinatesAndDirection.IsMatch(startingCoordinatesAndDirection))
            {
                MarsRoverPosition = startingCoordinatesAndDirection;
            }
            else
            {
                throw new ArgumentException($"the command must match the pattern {CommandPatterns._patternStartingCoordinatesAndDirection}");
            }

            if (CommandPatterns._patternInstructionsForMoving.IsMatch(instructionsForMoving))
            {
                InstructionsForMoving = instructionsForMoving;
            }
            else
            {
                throw new ArgumentException($"the command must match the pattern {CommandPatterns._patternInstructionsForMoving}");
            }
            
            this.motionController = motionController;
        }
        internal string Move()
        {
            isTheMarsRoverMoving = true;
            MarsRoverPosition = motionController.MovingTheMarsRover(InstructionsForMoving);
            isTheMarsRoverMoving = false;
            return MarsRoverPosition;
        }
    }
}
