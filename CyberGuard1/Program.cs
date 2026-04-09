using System;
using CyberGuard;

namespace CyberGuard1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 🎨 ASCII ART
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
  /$$$$$$  /$$     /$$ /$$$$$$$  /$$$$$$$$ /$$$$$$$   /$$$$$$  /$$   /$$  /$$$$$$  /$$$$$$$  /$$$$$$$ 
 /$$__  $$|  $$   /$$/| $$__  $$| $$_____/| $$__  $$ /$$__  $$| $$  | $$ /$$__  $$| $$__  $$| $$__  $$
| $$  \__/ \  $$ /$$/ | $$  \ $$| $$      | $$  \ $$| $$  \__/| $$  | $$| $$  \ $$| $$  \ $$| $$  \ $$
| $$        \  $$$$/  | $$$$$$$ | $$$$$   | $$$$$$$/| $$ /$$$$| $$  | $$| $$$$$$$$| $$$$$$$/| $$  | $$
| $$         \  $$/   | $$__  $$| $$__/   | $$__  $$| $$|_  $$| $$  | $$| $$__  $$| $$__  $$| $$  | $$
| $$    $$    | $$    | $$  \ $$| $$      | $$  \ $$| $$  \ $$| $$  | $$| $$  | $$| $$  \ $$| $$  | $$
|  $$$$$$/    | $$    | $$$$$$$/| $$$$$$$$| $$  | $$|  $$$$$$/|  $$$$$$/| $$  | $$| $$  | $$| $$$$$$$/
 \______/     |__/    |_______/ |________/|__/  |__/ \______/  \______/ |__/  |__/|__/  |__/|_______/ 
");
            Console.ResetColor();

            Console.WriteLine("========= Welcome to CyberGuard =========");

            // 🔊 Voice Greeting
            VoiceGreeting voice = new VoiceGreeting();
            voice.PlayGreeting();

            // 👤 NAME VALIDATION
            string name;

            while (true)
            {
                Console.Write("Enter your Name: ");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Name cannot be empty.");
                    continue;
                }

                bool isValid = true;

                foreach (char c in name)
                {
                    if (!char.IsLetter(c))
                    {
                        isValid = false;
                        break;
                    }
                }

                if (!isValid)
                {
                    Console.WriteLine("Name must contain letters only.");
                    continue;
                }

                break;
            }

            Console.WriteLine($"Hello {name}, welcome to CyberGuard!");

            // 🤖 START CHATBOT
            Chatbot bot = new Chatbot();
            bot.StartChat(name);
        }
    }
}
