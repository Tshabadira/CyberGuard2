using System.Media;

namespace CyberGuard1
{
    private void  VoiceGreeting()
    {
        try {
           string path = "welcome.wav";
           SoundPlayer player = new SoundPlayer(path);
              player.Load();
                player.PlaySync();

    }
        catch (Exception ex)
            {
            Console.WriteLine("Voice greeting could not play");
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
}
}