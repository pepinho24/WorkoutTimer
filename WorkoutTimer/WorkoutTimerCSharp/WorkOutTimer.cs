namespace WorkoutTimerCSharp
{
    using System;
    using System.Threading;

    public class WorkOutTimer
    {
        public static void Main()
        {
            RunTimer();
            //var player = new MusicPlayer();

            //player.open(@"E:/MyMusicFile.mp3");
            //Console.WriteLine("Playing file!");
            //Thread.Sleep(20000);
            //player.pause();
            //Console.WriteLine("Paused!");
            //Thread.Sleep(2000);
            //player.play();
            //Console.WriteLine("Playing again!");
            //Thread.Sleep(20000);
        }

        private static void GetUserSettings(out int numOfReps, out int numOfExercises, out int numOfSeries, out int restTimeBetweenSeries, out int restTimeBetweenExercises, out int repTime)
        {
            Console.Write("Enter num of reps: ");
            numOfReps = int.Parse(Console.ReadLine());

            Console.Write("Enter num of exercises: ");
            numOfExercises = int.Parse(Console.ReadLine());

            Console.Write("Enter num of series: ");
            numOfSeries = int.Parse(Console.ReadLine());

            // in seconds
            Console.Write("Rest time between Series (in seconds): ");
            restTimeBetweenSeries = int.Parse(Console.ReadLine());

            Console.Write("Rest time between Exercises (in seconds): ");
            restTimeBetweenExercises = int.Parse(Console.ReadLine());

            Console.Write("Approximate time of Repetition (in seconds): ");
            repTime = int.Parse(Console.ReadLine());
            // int serieTime = repTime * numOfReps;
        }

        private static void RunTimer()
        {

            int numOfReps;
            int numOfExercises;
            int numOfSeries;

            int restTimeBetweenSeries;
            int restTimeBetweenExercises;

            int repTime;

            GetUserSettings(out numOfReps, out numOfExercises, out numOfSeries, out restTimeBetweenSeries, out restTimeBetweenExercises, out repTime);

            var player = new MusicPlayer();

            //player.open(@"E:/MyMusicFile.mp3");
            //Console.WriteLine("Playing file!");
            //Thread.Sleep(20000);
            //player.pause();
            //Console.WriteLine("Paused!");
            //Thread.Sleep(2000);
            //player.play();
            //Console.WriteLine("Playing again!");
            //Thread.Sleep(20000);

            Console.WriteLine("Starting the timer...");
            Console.WriteLine("Playing file!");
            
            player.open(@"E:/MyMusicFile.mp3");
            
            for (int exerciseNumber = 0; exerciseNumber < numOfExercises; exerciseNumber++)
            {
                Console.WriteLine("Exercise number {0}", exerciseNumber + 1);


                for (int serieNumber = 0; serieNumber < numOfSeries; serieNumber++)
                {
                    Console.WriteLine("Serie number {0}", serieNumber + 1);
                    player.play();

                    for (int repetitionNumber = 0; repetitionNumber < numOfReps; repetitionNumber++)
                    {
                        Thread.Sleep(repTime * 1000);
                        Console.WriteLine(repetitionNumber + 1);
                    }

                    if (serieNumber < numOfSeries - 1)
                    {
                        player.pause();
                        Console.WriteLine("Resting between series...");
                        Thread.Sleep(restTimeBetweenSeries * 1000);
                    }
                }

                if (exerciseNumber < numOfExercises - 1)
                {
                    player.pause();
                    Console.WriteLine("Resting between exercises...");
                    Thread.Sleep(restTimeBetweenExercises * 1000);
                }
            }

            Console.WriteLine("Workout Complete!");
        }
    }
}
