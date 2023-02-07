using System.Diagnostics;

namespace Examples.BigO
{
    public static class BigO
    {
        // O(2N)= O(N)
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

            Console.WriteLine($"Sum:{sum}-Elapsed time:{sumForElapsedTime}-Elapsed ticks:{sumStopWatch.ElapsedTicks}, Product:{product}-Elapsed time:{productForElapsedTime}-Elapsed ticks:{productStopWatch.ElapsedTicks}\n");


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
                    Console.Write($"i:{array[i]}, j:{array[j]} | ");
                }

                Console.Write('\n');
            }

            stopWatch.Stop();
            TimeSpan timeSpan = stopWatch.Elapsed;
            string elapsedTime = $"{timeSpan.Seconds:D}:{timeSpan.Milliseconds:D}:{timeSpan.Microseconds:D}:{timeSpan.Nanoseconds:D}";

            Console.WriteLine($"Elapsed time:{elapsedTime}-Elapsed ticks:{stopWatch.ElapsedTicks}\n");
        }


        //N2/2 = O(N²)
        public static void PrintUnorderedPairs(int[] array)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    Console.Write($"i:{array[i]}, j:{array[j]} | ");
                }

                Console.Write('\n');
            }

            stopWatch.Stop();
            TimeSpan timeSpan = stopWatch.Elapsed;
            string elapsedTime = $"{timeSpan.Seconds:D}:{timeSpan.Milliseconds:D}:{timeSpan.Microseconds:D}:{timeSpan.Nanoseconds:D}";

            Console.WriteLine($"Elapsed time:{elapsedTime}-Elapsed Ticks:{stopWatch.ElapsedTicks}\n");
        }

        // O(ab) - two different inputs (arrays)
        public static void PrintUnorderedPairs(int[] arrayA, int[] arrayB)
        {
            Stopwatch firstForStopWatch = new Stopwatch();
            Stopwatch secondForStopWatch = new Stopwatch();

            firstForStopWatch.Start();
            for (int i = 0; i < arrayA.Length; i++)
            {
                secondForStopWatch.Start();
                for (int j = 0; j < arrayB.Length; j++)
                {
                    if (arrayA[i] < arrayB[j])
                    {
                        Console.Write($"i:{arrayA[i]}, j:{arrayB[j]} | ");
                    }
                }

                secondForStopWatch.Stop();
                Console.Write('\n');
            }

            firstForStopWatch.Stop();
            TimeSpan firstForTimeSpan = firstForStopWatch.Elapsed;
            TimeSpan secondForTimeSpan = secondForStopWatch.Elapsed;


            string firstForElapsedTime = $"{firstForTimeSpan.Seconds:D}:{firstForTimeSpan.Milliseconds:D}:{firstForTimeSpan.Microseconds:D}:{firstForTimeSpan.Nanoseconds:D}";
            string secondForElapsedTime = $"{secondForTimeSpan.Seconds:D}:{secondForTimeSpan.Milliseconds:D}:{secondForTimeSpan.Microseconds:D}:{secondForTimeSpan.Nanoseconds:D}";

            Console.WriteLine($"First For elapsed time:{firstForElapsedTime}-Elapsed ticks:{firstForStopWatch.ElapsedTicks}-Second For elapsed time:{secondForElapsedTime}-Elapsed ticks:{secondForStopWatch.ElapsedTicks}\n");
        }

        // O(ab) - third for is a constant
        public static void PrintUnorderedPairsWithExtraFor(int[] arrayA, int[] arrayB)
        {
            Stopwatch firstForStopWatch = new Stopwatch();
            Stopwatch secondForStopWatch = new Stopwatch();

            firstForStopWatch.Start();
            for (int i = 0; i < arrayA.Length; i++)
            {
                secondForStopWatch.Start();
                for (int j = 0; j < arrayA.Length; j++)
                {
                    for (int k = 1; k <= 50; k++)
                    {
                        Console.Write($"k:{k}, i:{arrayA[i]}, j:{arrayB[j]} | ");
                    }

                    secondForStopWatch.Stop();
                    Console.Write('\n');
                }
            }

            firstForStopWatch.Stop();
            TimeSpan firstForTimeSpan = firstForStopWatch.Elapsed;
            TimeSpan secondForTimeSpan = secondForStopWatch.Elapsed;


            string firstForElapsedTime = $"{firstForTimeSpan.Seconds:D}:{firstForTimeSpan.Milliseconds:D}:{firstForTimeSpan.Microseconds:D}:{firstForTimeSpan.Nanoseconds:D}";
            string secondForElapsedTime = $"{secondForTimeSpan.Seconds:D}:{secondForTimeSpan.Milliseconds:D}:{secondForTimeSpan.Microseconds:D}:{secondForTimeSpan.Nanoseconds:D}";

            Console.WriteLine($"First For elapsed time:{firstForElapsedTime}-Elapsed ticks:{firstForStopWatch.ElapsedTicks}-Second For elapsed time:{secondForElapsedTime}-Elapsed ticks:{secondForStopWatch.ElapsedTicks}\n");
        }
    }
}