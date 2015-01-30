namespace WorkoutTimerCSharp
{
    using System;
    using System.Threading;

    public class WorkOutTimer
    {
        public static void Main()
        {
            RunTimer();
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
            Console.Write("Rest time between series (in seconds): ");
            restTimeBetweenSeries = int.Parse(Console.ReadLine());

            Console.Write("Rest time between Exercises (in seconds): ");
            restTimeBetweenExercises = int.Parse(Console.ReadLine());

            Console.Write("Aproximate time of repetition (in seconds): ");
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

            Console.WriteLine("Starting the timer...");

            for (int exerciseNumber = 0; exerciseNumber < numOfExercises; exerciseNumber++)
            {
                Console.WriteLine("Exercise number {0}", exerciseNumber + 1);

                for (int serieNumber = 0; serieNumber < numOfSeries; serieNumber++)
                {
                    Console.WriteLine("Serie number {0}", serieNumber + 1);

                    for (int repetitionNumber = 0; repetitionNumber < numOfReps; repetitionNumber++)
                    {
                        Thread.Sleep(repTime * 1000);
                        Console.WriteLine(repetitionNumber + 1);
                    }

                    if (serieNumber < numOfSeries - 1)
                    {
                        Console.WriteLine("Resting between series...");
                        Thread.Sleep(restTimeBetweenSeries * 1000);
                    }
                }

                if (exerciseNumber < numOfExercises - 1)
                {
                    Console.WriteLine("Resting between exercises...");
                    Thread.Sleep(restTimeBetweenExercises * 1000);
                }
            }

            Console.WriteLine("Workout Complete!");
        }
    }
}
