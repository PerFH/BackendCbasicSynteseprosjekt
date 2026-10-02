
public class CommandExecution
{
    PositionOrientation positionOrientation = new PositionOrientation();
    CommandValidation validated = new CommandValidation();


    void executeCommand()
    {
        //hvis kommandoen er både gyldig og mulig å gjennomføre så gjennomfører den kommandoen, og sender til logg som info
    }

    void turnLeftCommand(string currentDirection)
    {
        if (positionOrientation.currentDirection == "NORTH")
        {
            positionOrientation.currentDirection = "WEST";
        }
        else if (positionOrientation.currentDirection == "WEST")
        {
            positionOrientation.currentDirection = "SOUTH";
        }
        else if (positionOrientation.currentDirection == "SOUTH")
        {
            positionOrientation.currentDirection = "EAST";
            
        }
        else 
        {
            positionOrientation.currentDirection = "NORTH";

        }
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
        else
        {
            positionOrientation.currentDirection = "SOUTH";
        }
    }
    void moveCommand()
    {
        if (positionOrientation.currentDirection == "NORTH")
        {
            positionOrientation.yPosition(1);
        }
        if (positionOrientation.currentDirection == "WEST")
        {
            positionOrientation.xPosition(-1);
        }
        if (positionOrientation.currentDirection == "SOUTH")
        {
            positionOrientation.yPosition(-1);
        }
        if (positionOrientation.currentDirection == "EAST")
        {
            positionOrientation.xPosition(1);
        }
    }

    void reportCommand(int xposition, int yposition, string currentDirection)
    {
        Console.WriteLine($"Current coordinates X: {xposition}, Y: {yposition} Facing: {currentDirection}");
    }
}
