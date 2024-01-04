using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.ComponentModel;

namespace My_2024_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //TerminalFunctions();
            //LetsDoMath();
            //FunWithArrays();
            //AssignValueInArray();
            LearningLists();
        }

        public static void LearningLists()
        {
            List<string> Name = new List<string>();

            // To add an item to a list, simply use ".Add()"
            Name.Add("Tommy");
            Name.Add("Mike");
            Name.Add("Shawn");
            Name.Add("Sally");

            for(int i = 0; i<Name.Count; i++){
                Console.WriteLine(Name[i]);
            }

            Console.WriteLine("------------------------");

            //Benefit of using a list instead of an Array
            //Is the fact that you can add or remove specific elements via name or index.
            
            // Removing by specific element
            Name.Remove("Tommy");
            // Removing by List index
            Name.Remove(Name[0]);
            // Removing by builtin RemoveAt
            Name.RemoveAt(0);
            
            for(int i = 0; i<Name.Count; i++){
                Console.WriteLine(Name[i]);
            }

            Console.ReadKey();
        }

        public static void FunWithArrays()
        {
            //Creating a string array called movies to hold specific movie names.
            string[] movies = {"Harry Potter", "Lord of the Rings", "Home Alone", "Chicken Little"};

            // iterating through the string array to print out the movie names on Keypress.
            for(int i = 0; i < movies.Length; i++){
                Console.WriteLine(movies[i]);
                Console.ReadKey();
            }
        }

        public static void AssignValueInArray()
        {
            string[] fruits = new string[4];
        
            Console.WriteLine("Enter 4 fruits of your choice: ");

            for(int i = 0; i <= 3; i++){
                fruits[i] = Console.ReadLine();
            }
            //Sorts the array in alphabetical order.
            Array.Sort(fruits);

            for(int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            Console.ReadKey();
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