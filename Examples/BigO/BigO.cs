using System.Diagnostics;

namespace Examples.BigO
{
    public static class BigO
    {
        public static void Foo(int[] array)
        {
            int sum = 0;
            int product = 1;
            Stopwatch sumStopWatch = new Stopwatch();
            Stopwatch productStopWatch = new Stopwatch();


            sumStopWatch.Start();
            for (int i = 0; i < array.Length; i++)
            {
                sum += i;
            }
            sumStopWatch.Stop();
            TimeSpan sumTimeSpan = sumStopWatch.Elapsed;

            productStopWatch.Start();
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];

            }
            productStopWatch.Stop();
            TimeSpan productTimeSpan = productStopWatch.Elapsed;


            string sumForElapsedTime = $"{sumTimeSpan.Seconds / 10:00}:{sumTimeSpan.Milliseconds / 10:00}:{sumTimeSpan.Microseconds / 10:00}:{sumTimeSpan.Nanoseconds / 10:00}";
            string productForElapsedTime = $"{productTimeSpan.Seconds / 10:00}:{productTimeSpan.Milliseconds / 10:00}:{productTimeSpan.Microseconds / 10:00}:{productTimeSpan.Nanoseconds / 10:00}";

            Console.WriteLine($"Sum:{sum}-Elapsed time:{sumForElapsedTime}-Elapsed ticks:{sumStopWatch.ElapsedTicks}," +
                              $"Product:{product}-Elapsed time:{productForElapsedTime}-Elapsed ticks:{productStopWatch.ElapsedTicks}");
        }
    }
}