using MarsRoversControlV2.Abstractions;

namespace MarsRoversControlV2
{
    internal class MarsRoverMoves : MarsRoverStatus
    {
        private MovingOneStep move = new MovingOneStep();
        public override void Action(MotionController motionController, char actionSymbol)
        {
            move.MovingTheMarsRoverOneStep(motionController);
        }
    }
}
