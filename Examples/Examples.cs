using System.Text;

namespace Examples
{
    internal class Examples
    {
        private static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            int number = 1;
            int[] array = Enumerable.Repeat(0, 25).Select(value => number++).ToArray();

            Console.WriteLine("Example 1: O(N)");
            BigO.BigO.Foo(array);

            Console.WriteLine("Example 2: O(N²)");
            BigO.BigO.PrintPairs(array);

            Console.WriteLine("Example 3: O(N²)");
            BigO.BigO.PrintUnorderedPairs(array);


            Console.WriteLine("Example 4: O(ab)");
            int[] arrayB = Enumerable.Repeat(0, 25).Select(value => number++).ToArray();
            BigO.BigO.PrintUnorderedPairs(array, arrayB);
        }
    }
}