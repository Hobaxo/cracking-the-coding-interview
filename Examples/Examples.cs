namespace Examples
{
    internal class Examples
    {
        private static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Example 1: O(N)");
            int number = 1;
            int[] array = Enumerable.Repeat(0, 25).Select(value => number++).ToArray();
            BigO.BigO.Foo(array);

            Console.WriteLine("Example 2: O(N²)");
            BigO.BigO.PrintPairs(array);
        }
    }
}