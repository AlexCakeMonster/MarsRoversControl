using MarsRoversControlV2.Abstractions;
using System.Diagnostics;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("MarsRoversControlV2Tests")]

namespace MarsRoversControlV2
{
    public class SquadOfMarsRovers
    {
        internal List<MarsRover> marsRovers = new();
        public string[] stoppingPointOfTheMarsRovers;
        private Plateaus Plateau { get; }

        public SquadOfMarsRovers(string upperRightPlateauCoordinates)
        {
            Plateau = new Plateau(upperRightPlateauCoordinates.ToUpper());
        }
        /// <summary>
        /// Adding a rover for the exploration mission
        /// </summary>
        /// <param name="coordinatesAndDirection">Coordinates of the rover's starting position and its starting direction</param>
        /// <param name="instructionsForMoving">Instructions for moving the rover across the plateau</param>
        public void AddMarsRover(string coordinatesAndDirection, string instructionsForMoving)
        {
            MotionController motionController = new MarsRoverMotionController(coordinatesAndDirection.ToUpper(), Plateau, marsRovers);
            marsRovers.Add(new MarsRover(coordinatesAndDirection.ToUpper(), instructionsForMoving.ToUpper(), motionController));
        }
        /// <summary>
        /// Gives the command to the rover squad to begin exploring the plateau
        /// </summary>
        public void StartResearch()
        {
            stoppingPointOfTheMarsRovers = new string[marsRovers.Count];
            for (int i = 0; i < marsRovers.Count; i++)
            {
                stoppingPointOfTheMarsRovers[i] = marsRovers[i].Move();
                while (marsRovers[i].isTheMarsRoverMoving)
                {
                    Debug.Write(".");
                }
            }
        }
    }
}
