namespace WorkoutTimerCSharp
{
    using System;
    public interface IMusicPlayer
    {
        void open(string file);
        void pause();
        void play();
        void stop();
    }
}
