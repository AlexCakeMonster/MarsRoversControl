namespace MarsRoversControlV2.Abstractions
{
    internal abstract class Detector
    {
        public abstract bool Сheck(MotionController motionController, char direction);
    }
}
