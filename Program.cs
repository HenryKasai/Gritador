using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Digite algo.");
            string grito = Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(grito.ToUpper());
            Console.WriteLine("Okay... Por que você está gritando comigo?");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
