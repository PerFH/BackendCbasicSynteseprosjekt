using System.Data;
class Program()
{
    static void Main(string[] args)
    {
        Console.WriteLine("Initiating boot sequence...");
    GetCommands commands = new GetCommands();
    commands.readMission();
    foreach (string command in commands.ReadCommands)
        {
            Console.WriteLine(command);
        }
    }
}