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
                var logLine = $"{DateTime.Now} [INFO] Read line: {line} from {getFile()}";
                File.AppendAllText("mission-report.txt", logLine + "\n");
                {
                    
                } 
            }
        }
    }
}


