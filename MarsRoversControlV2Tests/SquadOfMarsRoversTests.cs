using MarsRoversControlV2;

namespace MarsRoversControlV2Tests
{
    [TestClass]
    public class SquadOfMarsRoversTests
    {
        [TestMethod]
        public void StartResearch_MovingMarsRoversAccordingToGivenInstructions()
        {
            var marsRovers = new SquadOfMarsRovers("5 5");
            marsRovers.AddMarsRover("1 2 N", "LMLMLMLMM");
            marsRovers.AddMarsRover("3 3 E", "MMRMMRMRRM");
            //marsRovers.AddMarsRover("4 3 E", "MMRMMRMRRM");
            marsRovers.StartResearch();
            string expected1 = "1 3 N";
            string expected2 = "5 1 E";
            Assert.AreEqual(expected1, marsRovers.stoppingPointOfTheMarsRovers[0]);
            Assert.AreEqual(expected2, marsRovers.stoppingPointOfTheMarsRovers[1]);
        }

        [TestMethod]
        public void AddMarsRover_StartingCoordinatesAndDirectionInstructionsForMoving_ListMarsRoversIsNotNull()
        {
            var marsRovers = new SquadOfMarsRovers("5 5");
            marsRovers.AddMarsRover("1 2 N", "LMLMLMLMM");
            Assert.IsNotNull(marsRovers.marsRovers);
        }
    }
}
