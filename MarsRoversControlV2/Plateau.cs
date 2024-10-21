using MarsRoversControlV2.Abstractions;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MarsRoversControlV2Tests")]

namespace MarsRoversControlV2
{
    internal class Plateau : Plateaus
    {
        internal Plateau(string upperRightCoordinatesOfThePlateau)
        {
            ExtractingCoordinates(upperRightCoordinatesOfThePlateau);
        }

        private void ExtractingCoordinates(string coordinate)
        {
            if (CommandPatterns._patternUpperRightPlateauCoordinates.IsMatch(coordinate))
            {
                string[] coordinates = coordinate.Split(" ");
                UpperOfThePlateauX = int.Parse(coordinates[0]);
                UpperOfThePlateauY = int.Parse(coordinates[1]);
            }
            else
            {
                throw new ArgumentException($"the command must match the pattern {CommandPatterns._patternUpperRightPlateauCoordinates}");
            }
        }

    }
}
