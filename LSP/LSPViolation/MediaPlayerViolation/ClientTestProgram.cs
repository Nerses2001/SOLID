
namespace SOLID.LSP.LSPViolation.MediaPlayerViolation
{
    internal class ClientTestProgram
    {
       public static void  ClientMain() 
        {
            List<MediaPlayer> allPlayers = new ();
            allPlayers.Add(new VlcMediaPlayer());
            allPlayers.Add(new TorMediaPlayer());
            PlayVidoInAllMEdiaPlayers(allPlayers);
            Console.WriteLine(new string('_',50));
            allPlayers.Add (new WinampMediaPlayer());
            new WinampMediaPlayer().PlayVideo();
            PlayVidoInAllMEdiaPlayers (allPlayers);
        }

        private static void PlayVidoInAllMEdiaPlayers(List<MediaPlayer> allPlayers)
        {
            foreach (MediaPlayer player in allPlayers)
            {
                player.PlayVideo();
            }
        }
    }
}
