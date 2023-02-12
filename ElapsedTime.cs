using System;

namespace Utilities
{
    public class ElapsedTime
    {
        public ElapsedTime()
        {
            public static void PrintElapsedTime()
            {
                TimeSpan firstForTimeSpan = firstForStopWatch.Elapsed;
                TimeSpan secondForTimeSpan = secondForStopWatch.Elapsed;

                string firstForElapsedTime = $"{firstForTimeSpan.Seconds:D}:{firstForTimeSpan.Milliseconds:D}:{firstForTimeSpan.Microseconds:D}:{firstForTimeSpan.Nanoseconds:D}";
                string secondForElapsedTime = $"{secondForTimeSpan.Seconds:D}:{secondForTimeSpan.Milliseconds:D}:{secondForTimeSpan.Microseconds:D}:{secondForTimeSpan.Nanoseconds:D}";

                Console.WriteLine($"First For elapsed time:{firstForElapsedTime}-Elapsed ticks:{firstForStopWatch.ElapsedTicks}-Second For elapsed time:{secondForElapsedTime}-Elapsed ticks:{secondForStopWatch.ElapsedTicks}\n");
            }
        }
    }
}