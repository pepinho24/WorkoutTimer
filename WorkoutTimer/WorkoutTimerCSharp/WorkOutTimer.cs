namespace WorkoutTimerCSharp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class WorkOutTimer
    {
        public static void Main()
        {
            Console.Write("Enter num of reps: ");
            int numOfReps = int.Parse(Console.ReadLine());

            Console.Write("Enter num of exercises: ");
            int numOfExercises = int.Parse(Console.ReadLine());

            Console.Write("Enter num of series: ");
            int numOfSeries = int.Parse(Console.ReadLine());

            // in seconds
            Console.Write("Rest time between series (in seconds): ");
            int restTimeBetweenSeries = int.Parse(Console.ReadLine());

            Console.Write("Rest time between Exercises (in seconds): ");
            int restTimeBetweenExercises = int.Parse(Console.ReadLine());

            Console.Write("Aproximate time of repetition (in seconds): ");
            int repTime = int.Parse(Console.ReadLine());
            // int serieTime = repTime * numOfReps;

            RunTimer(numOfReps, numOfExercises, numOfSeries, restTimeBetweenSeries, restTimeBetweenExercises, repTime);
        }

        private static void RunTimer(int numOfReps, int numOfExercises, int numOfSeries, int restTimeBetweenSeries, int restTimeBetweenExercises, int repTime)
        {

            Console.WriteLine("Starting the timer...");

            for (int i = 0; i < numOfExercises; i++)
            {
                Console.WriteLine("Exercise number {0}", i + 1);

                for (int j = 0; j < numOfSeries; j++)
                {
                    Console.WriteLine("Serie number {0}", j + 1);

                    for (int k = 0; k < numOfReps; k++)
                    {
                        Thread.Sleep(repTime * 1000);
                        Console.WriteLine(k + 1);
                    }

                    if (j < numOfSeries - 1)
                    {
                        Console.WriteLine("Resting between series...");
                        Thread.Sleep(restTimeBetweenSeries * 1000);
                    }
                }

                if (i < numOfSeries - 1)
                {
                    Console.WriteLine("Resting between exercises...");
                    Thread.Sleep(restTimeBetweenExercises * 1000);
                }
            }

            Console.WriteLine("Workout Complete!");
        }
    }
}
