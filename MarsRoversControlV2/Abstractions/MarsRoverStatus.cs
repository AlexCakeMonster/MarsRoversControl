namespace MarsRoversControlV2.Abstractions
{
    internal abstract class MarsRoverStatus
    {
        public abstract void Action(MotionController motionController, char direction);
    }
}
