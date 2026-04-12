using System;
using System.Media;

namespace CyberGuard
{
    internal class VoiceGreeting
    {
        public void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("welcome.wav.wav");
                player.PlaySync();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Voice file not found.");
                Console.ResetColor();
            }
        }
    }
}