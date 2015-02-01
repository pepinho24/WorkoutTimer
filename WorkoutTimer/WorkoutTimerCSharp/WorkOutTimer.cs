namespace WorkoutTimerCSharp
{
    using System;
    using System.Threading;

    public class WorkOutTimer
    {
        private const string TrainingTimeSong = @"E:/MyMusicFile.mp3";
        private const string RestTimeSong = @"E:/MyMusicFileResting.mp3";

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

        private static void GetUserSettings(out int numOfReps, out int numOfExercises, out int numOfSeries, 
            out int restTimeBetweenSeries, out int restTimeBetweenExercises, out int repTime)
        {
            numOfReps = 10;
            numOfExercises = 3;
            numOfSeries = 3;

            restTimeBetweenSeries = 30;
            restTimeBetweenExercises = 60;
            repTime = 3;


            Console.Write("Enter num of reps (default is 10): ");
            int.TryParse(Console.ReadLine(), out numOfReps);
            if (numOfReps < 1)
            {
                
                numOfReps = 10;
            }
            Console.WriteLine(numOfReps + " reps chosen.");
            Console.WriteLine();


            Console.Write("Enter num of exercises (default is 3): ");
            int.TryParse(Console.ReadLine(), out numOfExercises);
            if (numOfExercises < 1)
            {
                numOfExercises = 3;
            }

            Console.WriteLine(numOfExercises + " exercises chosen.");
            Console.WriteLine();

            Console.Write("Enter num of series: ");
            int.TryParse(Console.ReadLine(), out numOfSeries);
            if (numOfSeries < 1)
            {
                numOfSeries = 3;
            }

            Console.WriteLine(numOfSeries + " series chosen.");
            Console.WriteLine();

            // in seconds
            Console.Write("Rest time between Series (in seconds, default is 30): ");
            int.TryParse(Console.ReadLine(), out restTimeBetweenSeries);
            if (restTimeBetweenSeries < 1)
            {
                restTimeBetweenSeries = 30;
            }

            Console.WriteLine(restTimeBetweenSeries + " seconds rest time between series chosen.");
            Console.WriteLine();

            Console.Write("Rest time between Exercises (in seconds, default is 60): ");
            int.TryParse(Console.ReadLine(), out restTimeBetweenExercises);
            if (restTimeBetweenExercises < 1)
            {
                restTimeBetweenExercises = 60;
            }

            Console.WriteLine(restTimeBetweenExercises + " seconds rest time between exercises chosen.");
            Console.WriteLine();

            Console.Write("Approximate time of Repetition (in seconds, default is 3): ");
            int.TryParse(Console.ReadLine(), out repTime);
            if (repTime < 1)
            {
                repTime = 3;
            }

            Console.WriteLine(repTime + " seconds repetion time chosen.");
            Console.WriteLine();
            // int serieTime = repTime * numOfReps;
        }

        private static void CountDown(int time)
        {
            for (int i = 0; i < time; i++)
            {
                if (i >= time - 3 )
                {
                    Console.Beep(500,50);
                }
                Thread.Sleep(1000);
            }
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

            var trainingPlayer = new MusicPlayer();
            var restingPlayer = new MusicPlayer();

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

            trainingPlayer.open(TrainingTimeSong);
            restingPlayer.open(RestTimeSong);

            for (int exerciseNumber = 0; exerciseNumber < numOfExercises; exerciseNumber++)
            {
                Console.WriteLine("Exercise number {0}", exerciseNumber + 1);

                restingPlayer.pause();
                trainingPlayer.play();

                for (int serieNumber = 0; serieNumber < numOfSeries; serieNumber++)
                {
                    Console.WriteLine("Serie number {0}", serieNumber + 1);

                    restingPlayer.pause();
                    trainingPlayer.play();

                    for (int repetitionNumber = 0; repetitionNumber < numOfReps; repetitionNumber++)
                    {
                        Thread.Sleep(repTime * 1000);
                        Console.WriteLine(repetitionNumber + 1);
                    }

                    if (serieNumber < numOfSeries - 1)
                    {
                        trainingPlayer.pause();
                        restingPlayer.play();

                        Console.WriteLine("Resting between series...");
                        CountDown(restTimeBetweenSeries);
                    }
                }

                if (exerciseNumber < numOfExercises - 1)
                {
                    trainingPlayer.pause();
                    restingPlayer.play();

                    Console.WriteLine("Resting between exercises...");
                    CountDown(restTimeBetweenExercises);
                }
            }

            Console.WriteLine("Workout Complete!");
        }
    }
}
