using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Security.Cryptography.X509Certificates;

public class CommandValidation
{
    public void logging()
    {

    }
    public List<ValidatedCommand> validatedCommands = new List<ValidatedCommand>();
    string[] validParts =
    {"REPORT",
    "MOVE",
    "TURN",
    "LEFT",
    "RIGHT",
    "STRAIGHT"};
    void giveObjective()
    {
        //det som ikke blir sendt til feilmelding blir sendt til CommandsToExecute
    }

    public void validate(string command)
    {
        ValidatedCommand validatedCommand = new ValidatedCommand();
        string[] details = command.Split(' ');

        if (command == "REPORT")
        {
            validatedCommand.commandType = details[0];
            validatedCommand.commandDirection = "REPORT";
            validatedCommand.commandStrength = 0;
            validatedCommands.Add(validatedCommand);
            File.AppendAllText("mission-report.txt", $"{DateTime.Now} [INFO]: Validated command: REPORT \n");
            
        }
        else if (details.Length > 2 && validParts.Contains(details[0]) && validParts.Contains(details[1]))
        {
            validatedCommand.commandType = details[0];
            validatedCommand.commandDirection = details[1];
            int number;
            if (int.TryParse(details[2], out number))
            {

                validatedCommand.commandStrength = number;
                validatedCommands.Add(validatedCommand);
                 string logLine = $"{DateTime.Now} [INFO]: Validated: {command}";
                 File.AppendAllText("mission-report.txt", logLine + "\n");

            }
        }
        else
        {
            string logLine = $"{DateTime.Now} [WARNING]: {command} not a valid command";
            File.AppendAllText("mission-report.txt", logLine + "\n");
            //logError()
        }
    }


    /*
    foreach (string line in File.ReadAllLines(getFile()))
                {
                    string[] details = line.Split(' ');
                    Console.WriteLine($"{receivedCommand.commandType} {receivedCommand.commandStrength} {receivedCommand.commandDirection}");
                }

    */
}
public class ValidatedCommand
{
    public string commandType { get; set; }
    public string commandDirection { get; set; }
    public int commandStrength { get; set; }
}