using System;

namespace CasinoExamples
{
    public static class ArrayOperations
    {
        public static int Sum(int[] numbers)
        {
            int total = 0;
            foreach (var n in numbers) total += n;
            return total;
        }

        public static bool Contains(int[] numbers, int value)
        {
            foreach (var n in numbers)
            {
                if (n == value) return true;
            }
            return false;
        }

        public static void PrintReverse(string[] items)
        {
            for (int i = items.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
