using System.Security.Cryptography.X509Certificates;

public class GetCommands
{
    private List<string> readCommands = new List<string>();

    public IReadOnlyList<string> ReadCommands
    {
        get
        {
            return readCommands;
        }
    }
    public bool fileExists
    {
        get
        {
            return File.Exists(getFile());
        }
    }
    private string getFile()
    {
        return "Mission.txt";
    }
    public void readMission()
    {
        if (fileExists)
        {
            foreach (string line in File.ReadAllLines(getFile()))
            {
                readCommands.Add(line);
            }
        }
    }
}


/*
foreach (string line in File.ReadAllLines(getFile()))
            {
                string[] details = line.Split(' ');
                ReceivedCommand receivedCommand = new ReceivedCommand();
                receivedCommand.commandType = details[0];
                if (details.Length > 1)
                {
                receivedCommand.commandDirection = details[1];
                } 
                if (details.Length > 2)
                {
                    
                int number;
                if (int.TryParse(details[2], out number))
                {
                    receivedCommand.commandStrength = number;
                }
                }
                receivedCommands.Add(line);
                Console.WriteLine($"{receivedCommand.commandType} {receivedCommand.commandStrength} {receivedCommand.commandDirection}");
            }
*/