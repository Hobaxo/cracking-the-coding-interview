using System.Diagnostics;
using Utilities;

namespace Examples.BigO
{
    public static class BigO
    {
        // O(2N)= O(N)
        public static void Foo(int[] array)
        {
            int sum = 0;
            int product = 1;
            Stopwatch firstForStopWatch = new Stopwatch();
            Stopwatch secondForStopWatch = new Stopwatch();

            firstForStopWatch.Start();
            for (int i = 0; i < array.Length; i++)
            {
                sum += i;
            }
            firstForStopWatch.Stop();

            secondForStopWatch.Start();
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];

            }
            secondForStopWatch.Stop();

            ElapsedTime.PrintElapsedTime(firstForStopWatch, secondForStopWatch);
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

            ElapsedTime.PrintElapsedTime(stopWatch);
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

            ElapsedTime.PrintElapsedTime(stopWatch);
        }

        // O(AB) - two different inputs (arrays)
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

            ElapsedTime.PrintElapsedTime(firstForStopWatch, secondForStopWatch);
        }

        // O(AB ) - third for is a constant
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

            ElapsedTime.PrintElapsedTime(firstForStopWatch, secondForStopWatch);
        }

        // O(N/2)= O(N)
        public static void ArrayReversal(int[] array)
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            for (int i = 0; i < array.Length / 2; i++)
            {
                int reversalIndex = array.Length - i - 1;
                int value = array[reversalIndex];
                array[reversalIndex] = array[i];
                array[i] = value;
            }
            stopWatch.Stop();

            ElapsedTime.PrintElapsedTime(stopWatch);
        }
    }
}