using System;

namespace CasinoExamples
{
    public static class ReplaceAndPrintNames
    {
        // Two equivalent ways to replace entries in an array (in-place)
        public static void Replace(string[] names, string toFind, string replacement)
        {
            if (names == null) return;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == toFind)
                    names[i] = replacement;
            }

            foreach (var name in names)
                Console.WriteLine(name);
        }
    }
}
