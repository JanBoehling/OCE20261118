namespace OCE20261118
{
    internal class Program
    {
        private static readonly int ZERO = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int ForceQuit() => (1 / ZERO);
    }
}
