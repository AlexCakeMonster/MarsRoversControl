namespace MarsRoversControlV2.Abstractions
{
    internal abstract class MotionController
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public char MarsRoverDirection { get; set; }
        internal Plateaus Plateau { get; set; }
        public List<MarsRover> MarsRovers { get; set; }

        internal abstract string MovingTheMarsRover(string instructionsForMoving);
    }
}
