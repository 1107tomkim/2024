using System;

namespace My_2024_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Title changes the title of the terminal
            Console.Title = "ChatBox";

            // ForegroundColor changes the color of the terminal fonts.
            Console.ForegroundColor = ConsoleColor.Cyan;

            // WindowHeight changes the height of the terminal when loaded.
            Console.WindowHeight = 20;
            Console.WindowWidth = 100;

            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            if(name == "tommy")
            {
                Console.WriteLine("Nice to meet you " + name);
            }
            else
            {
                Console.WriteLine("HAH!! That is a funky name!");
            }
            Console.ReadKey();
        }
    }
}