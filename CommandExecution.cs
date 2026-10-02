
public class CommandExecution
{
    PositionOrientation positionOrientation = new PositionOrientation();
    CommandValidation validated = new CommandValidation();


    void executeCommand()
    {
        //hvis kommandoen er både gyldig og mulig å gjennomføre så gjennomfører den kommandoen, og sender til logg som info
    }

    string turnLeftCommand(string currentDirection)
    {
        if (positionOrientation.currentDirection == "NORTH")
        {
            currentDirection = "WEST";
            return currentDirection;
        }
        else if (positionOrientation.currentDirection == "WEST")
        {
            currentDirection = "SOUTH";
            return currentDirection;
        }
        else if (positionOrientation.currentDirection == "SOUTH")
        {
            currentDirection = "EAST";
            return currentDirection;
        }
        else //(positionOrientation.currentDirection() == "EAST")
        {
            currentDirection = "NORTH";
            return currentDirection;
        }
    //else/if blokk som oppdaterer currentOrientation, basert på currentorientation, og left/right sving
    }

    void turnRightcommand(string currentDirection)
    {
        if (positionOrientation.currentDirection == "NORTH")
        {
            positionOrientation.currentDirection = "EAST";
        }
        else if (positionOrientation.currentDirection == "WEST")
        {
            positionOrientation.currentDirection = "NORTH";
        }
        else if (positionOrientation.currentDirection == "SOUTH")
        {
            positionOrientation.currentDirection = "WEST";

        }
        else //(positionOrientation.currentDirection() == "EAST")
        {
            positionOrientation.currentDirection = "SOUTH";
        }
    }
    void moveCommand()
        {
        if (positionOrientation.currentDirection == "NORTH")
        {
            positionOrientation.xPosition(1);
        }
        if (positionOrientation.currentDirection == "WEST")
        {
            positionOrientation.yPosition(-1);
        }
        if (positionOrientation.currentDirection == "SOUTH")
        {
            positionOrientation.xPosition(-1);
        }
        if (positionOrientation.currentDirection == "EAST")
        {
            positionOrientation.yPosition(1);
        }
    //else/if blokk som oppdaterer xy koordinater, basert på currentOrientation
        }

    void reportCommand(int xposition, int yposition, string currentDirection)
        {
        Console.WriteLine($"Current coordinates X: {xposition}, Y: {yposition} Facing: {currentDirection}");
        //gir rapport om xy koordinater og orientering
        }
    }

    //list CommandsToExecute
