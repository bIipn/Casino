using System;

namespace CasinoExamples
{
    public static class RandomLoops
    {
        // Example: keep generating numbers until 7 appears.
        public static void DoUntilSevenDemo()
        {
            var random = new Random();
            int current;
            do
            {
                current = random.Next(1, 11);
                Console.WriteLine(current);
            } while (current != 7);
            Console.WriteLine("Stopped at 7 (do-while).\n");

            // Example: generate until number < 3
            current = random.Next(1, 11);
            while (current >= 3)
            {
                Console.WriteLine(current);
                current = random.Next(1, 11);
            }
            Console.WriteLine($"Last number (while): {current}");
        }
    }
}
