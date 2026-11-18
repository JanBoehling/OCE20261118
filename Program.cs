using System.Security.Principal;

namespace OCE20261118
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Leute");
            Console.WriteLine("Aber...");
            Console.WriteLine("Goodybe, World :(");
        }

        static void TerminateProject(int error)
        {
            Environment.Exit(0);
        }
    }
}
