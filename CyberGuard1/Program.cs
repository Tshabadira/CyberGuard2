using CyberGuard;
using System.Reflection.Metadata.Ecma335;

namespace CyberGuard1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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



            Console.WriteLine("======================================= Welcome to CyberGuard =======================================");

            string name;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Enter your Name: ");
                Console.ResetColor();

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

                break; // 
            }





            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Hello {name}, I am here to help you stay safe all the time ");
            Console.ResetColor();

           
            Chatbot bot = new Chatbot();
            bot.StartChat(name);
            VoiceGreeting voice = new VoiceGreeting( );
        }
    }
}
