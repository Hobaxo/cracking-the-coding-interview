using System.Diagnostics;

namespace Examples.BigO
{
    public static class BigO
    {
        // O(N)
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


            string sumForElapsedTime = $"{sumTimeSpan.Seconds:D}:{sumTimeSpan.Milliseconds:D}:{sumTimeSpan.Microseconds:D}:{sumTimeSpan.Nanoseconds:D}";
            string productForElapsedTime = $"{productTimeSpan.Seconds:D}:{productTimeSpan.Milliseconds:D}:{productTimeSpan.Microseconds:D}:{productTimeSpan.Nanoseconds:D}";

            Console.WriteLine($"Sum:{sum}-Elapsed time:{sumForElapsedTime}-Elapsed ticks:{sumStopWatch.ElapsedTicks}," +
                              $"Product:{product}-Elapsed time:{productForElapsedTime}-Elapsed ticks:{productStopWatch.ElapsedTicks}\n");


        }

        // O(N²)
        public static void PrintPairs(int[] array)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    Console.WriteLine("i:" + array[i] + "," + "j" + array[j]);
                }
            }

            stopWatch.Stop();
            TimeSpan timeSpan = stopWatch.Elapsed;
            string elapsedTime = $"{timeSpan.Seconds:D}:{timeSpan.Milliseconds:D}:{timeSpan.Microseconds:D}:{timeSpan.Nanoseconds:D}";

            Console.WriteLine($"Elapsed time:{elapsedTime}-Elapsed ticks:{stopWatch.ElapsedTicks}\n");
        }

    }
}