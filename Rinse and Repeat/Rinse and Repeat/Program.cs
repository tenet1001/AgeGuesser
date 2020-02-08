using System;

namespace Rinse_and_Repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            string version = "1.2.0";
            string title = "Age Guesser";
            string author = "Tenet";
            int age;
            int tries = 0;
            int maxTries = 3;
            int guesses = 0;
            int totalGuesses = 0;
            Console.WriteLine("Welcome to {0}! Version: {1} Author: {2}", title, version, author);
            while (true)
            {
                Console.WriteLine($"Tries: {tries} | Please input your age: ");
                
                var ageString = Console.ReadLine();

                if (Int32.TryParse(ageString, out age))
                {
                    if (age <= 100 && age >= 0)
                    {
                        Console.WriteLine("Is this right: Y/N: " + age);

                        if (Console.ReadKey().Key == ConsoleKey.Y) 
                        {

                        }
                    }
                    else Console.WriteLine("You are either too old to be alive or too young to be playing this game");
                }

                if (++tries > maxTries) break;
            }
        }
    }
}
