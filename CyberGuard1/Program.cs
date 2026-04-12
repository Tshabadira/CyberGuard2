using System;
using System.Threading;
using CyberGuard;

namespace CyberGuard1
{
    // Entry point of the CyberGuard application
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set the console window title
            Console.Title = "CyberGuard - Cybersecurity Awareness Chatbot";

            // Play voice greeting
            VoiceGreeting voice = new VoiceGreeting();
            voice.PlayGreeting();
            Thread.Sleep(400);

            // Display ASCII art banner
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
  ____        _                  ____                      _ 
 / ___|  _   | |__   ___ _ __  / ___|_   _  __ _ _ __ __| |
| |     | | | | '_ \ / _ \ '__| |  _| | | |/ _` | '__/ _` |
| |___  | |_| | |_) |  __/ |  | |_| | |_| | (_| | | | (_| |
 \____|  \__, |_.__/ \___|_|   \____|\__,_|\__,_|_|  \__,_|
         |___/                                               ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("============================================================");
            Console.WriteLine("          CYBERSECURITY AWARENESS CHATBOT");
            Console.WriteLine("     Your guide to staying safe in the digital world.");
            Console.WriteLine("============================================================");
            Console.ResetColor();

            Thread.Sleep(300);

            // Get and validate the user's name
            string name = GetValidatedName();

            // Start the chatbot
            Chatbot bot = new Chatbot();
            bot.StartChat(name);
        }

        // Asks the user for their name and validates the input
        private static string GetValidatedName()
        {
            string name;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n  Enter your name to get started: ");
                Console.ResetColor();

                name = Console.ReadLine();

                // Check if name is empty
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  Name cannot be empty. Please try again.");
                    Console.ResetColor();
                    continue;
                }

                name = name.Trim();

                // Check minimum length
                if (name.Length < 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  Name must be at least 2 characters. Please try again.");
                    Console.ResetColor();
                    continue;
                }

                // Check maximum length
                if (name.Length > 30)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  Name must be 30 characters or less. Please try again.");
                    Console.ResetColor();
                    continue;
                }

                // Check letters and spaces only
                bool isValid = true;
                foreach (char c in name)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        isValid = false;
                        break;
                    }
                }

                if (!isValid)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  Name must contain letters only. No numbers or symbols.");
                    Console.ResetColor();
                    continue;
                }

                // Name is valid
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n  Welcome, " + name + "! CyberGuard is loading...");
                Console.WriteLine("============================================================");
                Console.ResetColor();
                Thread.Sleep(600);
                break;
            }

            return name;
        }
    }
}