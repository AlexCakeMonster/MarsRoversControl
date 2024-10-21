using MarsRoversControlV2;
using static System.Console;

string upperRightPlateauCoordinates, startingCoordinatesAndDirection, instructionsForMoving;
while (true)
{
    Write("Enter the upper right coordinates of the plateau: ");
    upperRightPlateauCoordinates = Console.ReadLine().ToUpper();
    if (CommandPatterns._patternUpperRightPlateauCoordinates.IsMatch(upperRightPlateauCoordinates))
    {
        break;
    }
    else
    {
        Write($"Invalid value. The command must match the pattern {CommandPatterns._patternUpperRightPlateauCoordinates}.\n");
    }
}
SquadOfMarsRovers squadOfMarsRovers = new SquadOfMarsRovers(upperRightPlateauCoordinates);

Add();

bool running = true;
while (running)
{
    Write("Add another rover press - A\nStart exploration - S\n");
    switch (ReadKey(true).Key)
    {
        case ConsoleKey.A:
            Add();
            break;
        case ConsoleKey.S:
            squadOfMarsRovers.StartResearch();
            running = false;
            break;
        default:
            WriteLine("Press A or Enter");
            break;
    }
}

int count = 1;
foreach (var item in squadOfMarsRovers.stoppingPointOfTheMarsRovers)
{
    WriteLine($"Rover number {count} completed its exploration at coordinates: {item}");
    count++;
}

void Add()
{
    while (true)
    {
        Write("Enter data to add a rover to the mission: Start coordinates: ");
        startingCoordinatesAndDirection = Console.ReadLine().ToUpper();
        if (CommandPatterns._patternStartingCoordinatesAndDirection.IsMatch(startingCoordinatesAndDirection))
        {
            break;
        }
        else
        {
            WriteLine($"Invalid value. The command must match the pattern {CommandPatterns._patternStartingCoordinatesAndDirection}.\n");
        }
    }

    while (true)
    {
        Write("Enter the data to add the rover to the mission: Rover Movement Instructions: ");
        instructionsForMoving = Console.ReadLine().ToUpper();
        if (CommandPatterns._patternInstructionsForMoving.IsMatch(instructionsForMoving))
        {
            break;
        }
        else
        {
            Write($"Invalid value. The command must match the pattern {CommandPatterns._patternInstructionsForMoving}.\n");
        }
    }

    squadOfMarsRovers.AddMarsRover(startingCoordinatesAndDirection, instructionsForMoving);
}
