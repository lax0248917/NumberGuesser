using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Set App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Zach King";

            // Change Text Color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out App Info
            Console.WriteLine("{0} : Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset Console Color
            Console.ResetColor();

            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string input = Console.ReadLine();

            // Write out Greeting
            Console.WriteLine("Hello {0}. Let's play a game...", input);
        }
    }
}
