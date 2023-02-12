using System.Diagnostics;

namespace Utilities
{
    public class ElapsedTime
    {
        public static void PrintElapsedTime(Stopwatch firstForStopWatch, Stopwatch? secondForStopWatch = null)
        {
            TimeSpan firstForTimeSpan = firstForStopWatch.Elapsed;
            string firstForElapsedTime = $"{firstForTimeSpan.Seconds:D}:{firstForTimeSpan.Milliseconds:D}:{firstForTimeSpan.Microseconds:D}:{firstForTimeSpan.Nanoseconds:D}";

            if (secondForStopWatch != null)
            {
                PrintValuesForTwoStopWatches(firstForStopWatch, secondForStopWatch, firstForElapsedTime);
            }
            else
            {
                PrintValuesForSingleStopWatch(firstForStopWatch, firstForElapsedTime);
            }

        }

        #region Private Methods
        private static void PrintValuesForTwoStopWatches(Stopwatch firstForStopWatch, Stopwatch secondForStopWatch, string firstForElapsedTime)
        {
            TimeSpan secondForTimeSpan = secondForStopWatch.Elapsed;
            string secondForElapsedTime = $"{secondForTimeSpan.Seconds:D}:{secondForTimeSpan.Milliseconds:D}:{secondForTimeSpan.Microseconds:D}:{secondForTimeSpan.Nanoseconds:D}";
            Console.WriteLine($"First For elapsed time:{firstForElapsedTime}-Elapsed ticks:{firstForStopWatch.ElapsedTicks}-Second For elapsed time:{secondForElapsedTime}-Elapsed ticks:{secondForStopWatch.ElapsedTicks}\n");
        }

        private static void PrintValuesForSingleStopWatch(Stopwatch firstForStopWatch, string firstForElapsedTime)
        {
            Console.WriteLine($"Elapsed time:{firstForElapsedTime}-Elapsed Ticks:{firstForStopWatch.ElapsedTicks}\n");
        }
        #endregion

    }
}