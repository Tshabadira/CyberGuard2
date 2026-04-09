using System;
using System.Threading;

namespace CyberGuard
{
    internal class Chatbot
    {
        private string lastTopic = "";

        public void StartChat(string name)
        {
            TypeText($"\nHello {name}, I am CyberGuard 🤖");
            ShowMenu();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Error("Please type something.");
                    continue;
                }

                if (input == "exit")
                {
                    TypeText($"Goodbye {name}, stay safe online!");
                    break;
                }

                if (input.Contains("more"))
                {
                    GiveMoreDetails();
                    continue;
                }

                if (input.Contains("simple"))
                {
                    GiveSimpleExplanation();
                    continue;
                }

                switch (input)
                {
                    case "1": PasswordInfo(); break;
                    case "2": PhishingInfo(); break;
                    case "3": SafeBrowsing(); break;
                    case "4": MalwareInfo(); break;
                    case "5": TwoFactorAuth(); break;
                    case "6": SocialEngineering(); break;
                    case "7": PublicWifi(); break;
                    case "8": ShowMenu(); break;
                    default: Respond(input); break;
                }
            }
        }

        private void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n=== CYBER MENU ===");
            Console.WriteLine("1. Password Safety");
            Console.WriteLine("2. Phishing");
            Console.WriteLine("3. Safe Browsing");
            Console.WriteLine("4. Malware");
            Console.WriteLine("5. Two-Factor Authentication");
            Console.WriteLine("6. Social Engineering");
            Console.WriteLine("7. Public Wi-Fi Safety");
            Console.WriteLine("8. Show menu again");
            Console.ResetColor();
        }

        private void TypeText(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }

            Console.WriteLine();
            Console.ResetColor();
        }

        private void ShowLoading()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("CyberGuard is typing");

            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(300);
                Console.Write(".");
            }

            Console.WriteLine("\n");
            Console.ResetColor();
        }

        private void Error(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        private void PasswordInfo()
        {
            ShowLoading();
            lastTopic = "password";

            TypeText("Strong passwords should include letters, numbers, and symbols.");
            TypeText("Avoid using personal info.");
            TypeText("Change passwords regularly.");
        }

        private void PhishingInfo()
        {
            ShowLoading();
            lastTopic = "phishing";

            TypeText("Phishing tricks users into giving data.");
            TypeText("Fake emails and links are common.");
            TypeText("Always verify before clicking.");
        }

        private void SafeBrowsing()
        {
            ShowLoading();
            lastTopic = "browsing";

            TypeText("Use https websites.");
            TypeText("Avoid unknown downloads.");
            TypeText("Keep browser updated.");
        }

        private void MalwareInfo()
        {
            ShowLoading();
            lastTopic = "malware";

            TypeText("Malware is harmful software.");
            TypeText("Comes from unsafe downloads.");
            TypeText("Use antivirus protection.");
        }

        private void TwoFactorAuth()
        {
            ShowLoading();
            lastTopic = "2fa";

            TypeText("2FA adds extra security.");
            TypeText("Requires second verification step.");
            TypeText("Always enable it.");
        }

        private void SocialEngineering()
        {
            ShowLoading();
            lastTopic = "social";

            TypeText("Tricks users into giving info.");
            TypeText("Attackers pretend to be trusted.");
            TypeText("Always verify identity.");
        }

        private void PublicWifi()
        {
            ShowLoading();
            lastTopic = "wifi";

            TypeText("Public Wi-Fi is risky.");
            TypeText("Avoid sensitive logins.");
            TypeText("Use VPN if possible.");
        }

        private void Respond(string input)
        {
            if (input.Contains("password")) PasswordInfo();
            else if (input.Contains("phishing")) PhishingInfo();
            else if (input.Contains("browsing")) SafeBrowsing();
            else if (input.Contains("malware")) MalwareInfo();
            else if (input.Contains("2fa")) TwoFactorAuth();
            else if (input.Contains("social")) SocialEngineering();
            else if (input.Contains("wifi")) PublicWifi();

            else if (input.Contains("how are you"))
            {
                ShowLoading();
                TypeText("I'm doing great and ready to help.");
            }
            else if (input.Contains("purpose"))
            {
                ShowLoading();
                TypeText("My purpose is to guide you in cybersecurity.");
            }
            else
            {
                ShowLoading();
                Error("I didn’t understand that.");
            }
        }

        private void GiveMoreDetails()
        {
            ShowLoading();

            if (lastTopic == "password")
                TypeText("Use password managers and avoid reusing passwords.");
            else
                TypeText("Ask about a topic first.");
        }

        private void GiveSimpleExplanation()
        {
            ShowLoading();

            if (lastTopic == "password")
                TypeText("Use strong passwords.");
            else
                TypeText("Nothing to simplify.");
        }
    }
}