
class Program
{
    static void Main(string[] args)
    {
        Controller controller = new Controller();
        Console.WriteLine("Initiating boot sequence...");
        controller.startUp();
    }
}