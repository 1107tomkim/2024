using System;

namespace My_2024_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Title changes the title of the terminal
            Console.Title = "TimmyTommy";

            // ForegroundColor changes the color of the terminal fonts.
            Console.ForegroundColor = ConsoleColor.Cyan;

            // WindowHeight changes the height of the terminal when loaded.
            Console.WindowHeight = 20;
            Console.WindowWidth = 100;

            Console.WriteLine("Hello 2024");
            Console.ReadKey();
        }
    }
}