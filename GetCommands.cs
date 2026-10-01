public class GetCommands()
{
    private List<ReceivedCommand> receivedCommands = new List<ReceivedCommand>();
    public IReadOnlyList<ReceivedCommand> ReceivedCommands
    {
        get
        {
            return receivedCommands;
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
        return "mission.txt";
    }
    public void populateMission()
    {

        if (fileExists)
        {
            foreach (string line in File.ReadAllLines(getFile()))
            {
                string[] details = line.Split(' ');
                ReceivedCommand receivedCommand = new ReceivedCommand();
                receivedCommand.commandType = details[0];
                receivedCommand.commandStrength = int.Parse(details[1]);
                receivedCommand.commandDirection = details[2];
                receivedCommands.Add(receivedCommand);
            }
        }

    }
    public class ReceivedCommand
    {
        public string commandType { get; set; }
        public int commandStrength { get; set; }
        public string commandDirection { get; set; }
    }
}
