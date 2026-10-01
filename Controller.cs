using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Data;

public class Controller
{
    PositionOrientation positionOrientation = new PositionOrientation();
    GetCommands commands = new GetCommands();
    CommandValidation validation = new CommandValidation();
    public void startUp()
    {
            commands.readMission();
            foreach (string command in commands.ReadCommands)
        {
            validation.validate(command);
            
        
        }
        foreach (ValidatedCommand validatedCommand in validation.validatedCommands)
        {
            Console.WriteLine();
            Console.WriteLine(validatedCommand.commandType);
            Console.WriteLine(validatedCommand.commandStrength);
            Console.WriteLine(validatedCommand.commandDirection);
        }
    }
    
}