namespace SOLID.LSP.LSPViolation.MediaPlayerViolation
{
    internal class WinampMediaPlayer:MediaPlayer
    {
        public void PlayVideo() => throw new Exception("Exaption playing vido");
    }
}
