namespace OverloadsOppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintWelcomeMessage();
        }

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Hei og velkommen");
        }
        static void PrintWelcomeMessage(string name = "Terje")
        {
            Console.WriteLine($"Hei og velkommen {name}");
        }
    }
}
