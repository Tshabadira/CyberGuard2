using System;
using System.Threading;

namespace CyberGuard
{
    // This class handles all chatbot responses and user interaction
    internal class Chatbot
    {
        // Keeps track of the last topic the user asked about
        private string lastTopic = "";

        // Stores the user's name
        private string userName = "";

        // Starts the chat session
        public void StartChat(string name)
        {
            userName = name;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("============================================================");
            Console.WriteLine("  Hello " + userName + "! Welcome to CyberGuard.");
            Console.WriteLine("  I am your cybersecurity awareness assistant.");
            Console.WriteLine("============================================================");
            Console.ResetColor();
            ShowMenu();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nYou: ");
                Console.ResetColor();
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please type something. Type 8 to see the menu.");
                    Console.ResetColor();
                    continue;
                }

                input = input.Trim().ToLower();

                if (input == "exit" || input == "bye")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("  Goodbye " + userName + "! Stay safe online.");
                    Console.ResetColor();
                    break;
                }

                if (input == "more")
                {
                    GiveMoreDetails();
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

        // Shows the topic menu
        private void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n============================================================");
            Console.WriteLine("                    CYBERGUARD MENU");
            Console.WriteLine("============================================================");
            Console.WriteLine("  1. Password Safety");
            Console.WriteLine("  2. Phishing Awareness");
            Console.WriteLine("  3. Safe Browsing");
            Console.WriteLine("  4. Malware Protection");
            Console.WriteLine("  5. Two-Factor Authentication");
            Console.WriteLine("  6. Social Engineering");
            Console.WriteLine("  7. Public Wi-Fi Safety");
            Console.WriteLine("  8. Show menu again");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("  Type 'more' for extra info.");
            Console.WriteLine("  Type 'exit' to quit.");
            Console.WriteLine("============================================================");
            Console.ResetColor();
        }

        // Shows a loading animation
        private void ShowLoading()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nCyberGuard is thinking");
            for (int i = 0; i < 3; i++) { Thread.Sleep(300); Console.Write("."); }
            Console.WriteLine("\n");
            Console.ResetColor();
        }

        private void PasswordInfo()
        {
            ShowLoading();
            lastTopic = "password";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  PASSWORD SAFETY:");
            Console.WriteLine("  - Use at least 12 characters with letters, numbers and symbols.");
            Console.WriteLine("  - Never reuse the same password on different accounts.");
            Console.WriteLine("  - Use a password manager to keep your passwords safe.");
            Console.ResetColor();
        }

        private void PhishingInfo()
        {
            ShowLoading();
            lastTopic = "phishing";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  PHISHING:");
            Console.WriteLine("  - Fake emails trick you into giving away personal information.");
            Console.WriteLine("  - Always check the sender email before clicking any links.");
            Console.WriteLine("  - When in doubt, go directly to the website yourself.");
            Console.ResetColor();
        }

        private void SafeBrowsing()
        {
            ShowLoading();
            lastTopic = "browsing";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  SAFE BROWSING:");
            Console.WriteLine("  - Only visit websites that use HTTPS.");
            Console.WriteLine("  - Never download files from unknown websites.");
            Console.WriteLine("  - Keep your browser updated at all times.");
            Console.ResetColor();
        }

        private void MalwareInfo()
        {
            ShowLoading();
            lastTopic = "malware";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  MALWARE:");
            Console.WriteLine("  - Malware is harmful software that damages your device.");
            Console.WriteLine("  - Install a good antivirus and keep it updated.");
            Console.WriteLine("  - Never open email attachments from unknown senders.");
            Console.ResetColor();
        }

        private void TwoFactorAuth()
        {
            ShowLoading();
            lastTopic = "2fa";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  TWO-FACTOR AUTHENTICATION (2FA):");
            Console.WriteLine("  - 2FA adds a second layer of protection beyond your password.");
            Console.WriteLine("  - Enable it on your email, banking and social media accounts.");
            Console.WriteLine("  - Never share your 2FA code with anyone.");
            Console.ResetColor();
        }

        private void SocialEngineering()
        {
            ShowLoading();
            lastTopic = "social";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  SOCIAL ENGINEERING:");
            Console.WriteLine("  - Attackers pretend to be trusted people to steal your info.");
            Console.WriteLine("  - Always verify who you are talking to before sharing anything.");
            Console.WriteLine("  - Never give passwords over the phone or via email.");
            Console.ResetColor();
        }

        private void PublicWifi()
        {
            ShowLoading();
            lastTopic = "wifi";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  PUBLIC WI-FI SAFETY:");
            Console.WriteLine("  - Public Wi-Fi is risky as others can intercept your data.");
            Console.WriteLine("  - Avoid accessing banking or email on public networks.");
            Console.WriteLine("  - Use a VPN to keep your connection private.");
            Console.ResetColor();
        }

        // Handles typed keyword input
        private void Respond(string input)
        {
            if (input.Contains("password")) { PasswordInfo(); return; }
            if (input.Contains("phishing")) { PhishingInfo(); return; }
            if (input.Contains("browsing") || input.Contains("browser")) { SafeBrowsing(); return; }
            if (input.Contains("malware") || input.Contains("virus")) { MalwareInfo(); return; }
            if (input.Contains("2fa") || input.Contains("two factor")) { TwoFactorAuth(); return; }
            if (input.Contains("social")) { SocialEngineering(); return; }
            if (input.Contains("wifi") || input.Contains("wi-fi")) { PublicWifi(); return; }
            if (input.Contains("how are you"))
            {
                ShowLoading();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("  I am doing great and ready to help you, " + userName + "!");
                Console.ResetColor();
                return;
            }
            if (input.Contains("purpose") || input.Contains("what do you do"))
            {
                ShowLoading();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("  I am here to educate you on cybersecurity. Type 8 for the menu.");
                Console.ResetColor();
                return;
            }
            if (input.Contains("thank"))
            {
                ShowLoading();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("  You are welcome, " + userName + "! Stay cyber safe!");
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n  I did not understand that, " + userName + ".");
            Console.WriteLine("  Try: password, phishing, malware, wifi, 2fa. Or type 8 for the menu.");
            Console.ResetColor();
        }

        // Gives 2 extra details on the last topic
        private void GiveMoreDetails()
        {
            ShowLoading();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  MORE DETAILS:");

            if (lastTopic == "password")
            {
                Console.WriteLine("  - Use a passphrase: four random words joined together.");
                Console.WriteLine("  - Check haveibeenpwned.com to see if your password was leaked.");
            }
            else if (lastTopic == "phishing")
            {
                Console.WriteLine("  - Vishing is phishing done over phone calls.");
                Console.WriteLine("  - Smishing is phishing done through SMS messages.");
            }
            else if (lastTopic == "browsing")
            {
                Console.WriteLine("  - Use a privacy browser like Firefox or Brave.");
                Console.WriteLine("  - Use VirusTotal to check if a website is safe.");
            }
            else if (lastTopic == "malware")
            {
                Console.WriteLine("  - Ransomware locks your files and demands payment.");
                Console.WriteLine("  - Always back up your files to an external drive.");
            }
            else if (lastTopic == "2fa")
            {
                Console.WriteLine("  - Authenticator apps are safer than SMS codes.");
                Console.WriteLine("  - Store your backup codes somewhere safe offline.");
            }
            else if (lastTopic == "social")
            {
                Console.WriteLine("  - Baiting leaves infected USB drives in public places.");
                Console.WriteLine("  - Always challenge unknown visitors in your workplace.");
            }
            else if (lastTopic == "wifi")
            {
                Console.WriteLine("  - Fake hotspots can steal your data without you knowing.");
                Console.WriteLine("  - Use mobile data instead of public Wi-Fi when possible.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  Please select a topic first, then type 'more'.");
            }

            Console.ResetColor();
        }
    }
}