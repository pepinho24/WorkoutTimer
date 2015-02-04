namespace WorkoutTimerCSharp
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;
    using WMPLib;

    public class MusicPlayer : WorkoutTimerCSharp.IMusicPlayer
    {
        private WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
        
        public void open(string file)
        {
            wplayer.settings.autoStart = false;
            wplayer.settings.setMode("loop", true);
            wplayer.URL = file;
        }

        public void play()
        {
            wplayer.controls.play();
        }

        public void pause()
        {
            wplayer.controls.pause();
        }


        public void stop()
        {
            wplayer.controls.stop();
        }
    }
}
