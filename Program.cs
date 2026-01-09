using System;
using CasinoExamples;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SKU Parser ===");
        Console.WriteLine(SkuParser.Parse("01-MN-L"));
        Console.WriteLine();

        Console.WriteLine("=== Permission Checker ===");
        Console.WriteLine(PermissionChecker.Check("Admin|Manager", 53));
        Console.WriteLine();

        Console.WriteLine("=== Array Operations ===");
        int[] numbers = { 4, 8, 15, 16, 23, 42 };
        Console.WriteLine($"Sum: {ArrayOperations.Sum(numbers)}");
        Console.WriteLine($"Contains 42: {ArrayOperations.Contains(numbers, 42)}");
        Console.WriteLine("Reverse print:");
        ArrayOperations.PrintReverse(new string[] { "Alex", "Eddie", "David", "Michael" });
        Console.WriteLine();

        Console.WriteLine("=== Replace Names Demo ===");
        var names = new string[] { "Alex", "Eddie", "David", "Michael" };
        ReplaceAndPrintNames.Replace(names, "David", "Sammy");
        Console.WriteLine();

        Console.WriteLine("=== FizzBuzz ===");
        FizzBuzz.Run(1, 100);
        Console.WriteLine();

        Console.WriteLine("=== Random Loops Demo ===");
        RandomLoops.DoUntilSevenDemo();
        Console.WriteLine();

        Console.WriteLine("=== Combat Simulation ===");
        CombatSimulation.BasicFightDemo();
        Console.WriteLine();

        Console.WriteLine("=== Input Validation Demo (commented out) ===");
        Console.WriteLine("The sample InputValidator contains a safe example for prompting the user. Uncomment to test interactively.");
    }
}
