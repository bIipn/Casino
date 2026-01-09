using System;

namespace CasinoExamples
{
    public static class CombatSimulation
    {
        // Simple turn-based combat loop demonstration
        public static void BasicFightDemo()
        {
            var rand = new Random();
            int heroHealth = 10;
            int monsterHealth = 10;

            do
            {
                int heroDamage = rand.Next(1, 10);
                monsterHealth -= heroDamage;
                Console.WriteLine($"Hero hits monster for {heroDamage}. Monster health: {Math.Max(0, monsterHealth)}");

                if (monsterHealth <= 0) break;

                int monsterDamage = rand.Next(1, 10);
                heroHealth -= monsterDamage;
                Console.WriteLine($"Monster hits hero for {monsterDamage}. Hero health: {Math.Max(0, heroHealth)}");

            } while (heroHealth > 0 && monsterHealth > 0);

            Console.WriteLine(heroHealth > 0 ? "Hero wins!" : "Monster wins!");
        }
    }
}
