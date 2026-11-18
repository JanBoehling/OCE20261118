namespace OCE20261118
{
    internal class Program
    {
        private static readonly int ZERO = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Leute");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public static int ForceQuit() => (1 / ZERO);
    }
}
