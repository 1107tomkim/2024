using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace My_2024_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //TerminalFunctions();
            LetsDoMath();
        }

        public static int LetsDoMath()
        {
            Console.Title = "MathTime";
            int num1;
            int num2;

            Console.WriteLine("Welcome to simple Addition! Type any number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number you set for number 1 is : " + num1);
            Console.WriteLine("Now please insert the value for number 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            int total = num1 + num2;
            Console.WriteLine("The total of " + num1 + " + " + num2 + " is: " + total);


            Console.ReadKey();
            return total;
        }

        public static void TerminalFunctions()
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