using System.Security.Principal;

namespace OCE20261118
{
    internal class Program
    {
        private static readonly int ZERO = 0;

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

        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public static int ForceQuit() => (1 / ZERO * 100 / 2);
    }
}
