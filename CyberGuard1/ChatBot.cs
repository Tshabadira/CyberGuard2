using System;
using System.Threading;

namespace CyberGuard
{
    internal class Chatbot
    {
        private string lastTopic = "";

        public void StartChat(string name)
        {
            Console.WriteLine($"\nHello {name}, I am CyberGuard 🤖");
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

                if (input == "clear")
                {
                    Console.Clear();
                    ShowMenu();
                    continue;
                }

                if (input == "help")
                {
                    TypeText("You can choose a number from the menu or type your own question.");
                    continue;
                }

                if (input == "tips")
                {
                    ShowTips();
                    continue;
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

        // 🎨 MENU
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

        // ⚡ TYPING EFFECT
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

        // 🔄 LOADING
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

        // ❌ ERROR
        private void Error(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        // 🔐 PASSWORD
        private void PasswordInfo()
        {
            ShowLoading();
            lastTopic = "password";

            TypeText("Strong passwords should include letters, numbers, and symbols.");
            TypeText("Avoid using personal information like names or birthdays.");
            TypeText("Change your passwords regularly to stay secure.");
        }

        // 🎣 PHISHING
        private void PhishingInfo()
        {
            ShowLoading();
            lastTopic = "phishing";

            TypeText("Phishing tricks users into giving sensitive information.");
            TypeText("Attackers use fake emails and websites.");
            TypeText("Always verify links before clicking.");
        }

        // 🌐 BROWSING
        private void SafeBrowsing()
        {
            ShowLoading();
            lastTopic = "browsing";

            TypeText("Always use secure websites with https.");
            TypeText("Avoid unknown downloads and links.");
            TypeText("Keep your browser updated.");
        }

        // 🦠 MALWARE
        private void MalwareInfo()
        {
            ShowLoading();
            lastTopic = "malware";

            TypeText("Malware is harmful software that damages systems.");
            TypeText("It spreads through downloads and emails.");
            TypeText("Use antivirus protection.");
        }

        // 🔐 2FA
        private void TwoFactorAuth()
        {
            ShowLoading();
            lastTopic = "2fa";

            TypeText("Two-factor authentication adds extra security.");
            TypeText("It requires a second step like a code.");
            TypeText("Always enable it where possible.");
        }

        // 🧠 SOCIAL ENGINEERING
        private void SocialEngineering()
        {
            ShowLoading();
            lastTopic = "social";

            TypeText("Social engineering tricks people into sharing data.");
            TypeText("Attackers pretend to be trusted sources.");
            TypeText("Always verify identity.");
        }

        // 📶 WIFI
        private void PublicWifi()
        {
            ShowLoading();
            lastTopic = "wifi";

            TypeText("Public Wi-Fi is not secure.");
            TypeText("Avoid logging into sensitive accounts.");
            TypeText("Use VPN if possible.");
        }

        // 🧠 EXTRA TIPS
        private void ShowTips()
        {
            ShowLoading();

            TypeText("Tip 1: Never share your passwords.");
            TypeText("Tip 2: Keep your software updated.");
            TypeText("Tip 3: Avoid suspicious links.");
        }

        // 🔁 TEXT
        private void Respond(string input)
        {
            if (input.Contains("password")) PasswordInfo();
            else if (input.Contains("phishing")) PhishingInfo();
            else if (input.Contains("browsing")) SafeBrowsing();
            else if (input.Contains("malware")) MalwareInfo();
            else if (input.Contains("2fa")) TwoFactorAuth();
            else if (input.Contains("social")) SocialEngineering();
            else if (input.Contains("wifi")) PublicWifi();

            // hidden
            else if (input.Contains("how are you"))
            {
                ShowLoading();
                TypeText("I'm doing great and ready to help you.");
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

        // ➕ MORE
        private void GiveMoreDetails()
        {
            ShowLoading();

            if (lastTopic == "password")
                TypeText("Use password managers and never reuse passwords.");
            else if (lastTopic == "phishing")
                TypeText("Check sender emails carefully before trusting them.");
            else
                TypeText("Ask about a topic first.");
        }

        // ➖ SIMPLE
        private void GiveSimpleExplanation()
        {
            ShowLoading();

            if (lastTopic == "password")
                TypeText("Use strong passwords.");
            else if (lastTopic == "phishing")
                TypeText("Avoid fake emails.");
            else
                TypeText("Nothing to simplify.");
        }
    }
}