using System.Text.RegularExpressions;

namespace MarsRoversControlV2
{
    public static class CommandPatterns
    {
        public static readonly Regex _patternInstructionsForMoving = new ("^[LRM]+$");

        public static readonly Regex _patternStartingCoordinatesAndDirection = new (@"^\d+\s\d+\s[NSWE]$");

        public static readonly Regex _patternUpperRightPlateauCoordinates = new (@"^\d+\s\d+$");
    }
}
