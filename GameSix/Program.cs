using System;
using System.Linq;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many foes would you like to create?");
            int n = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Foe[] allFoes = new Foe[n];
            
            Console.WriteLine("\nNow, I will walk you through the creation for each foe.\n\n");

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Creating Foe {i} out of {n}...\n");
                Console.WriteLine($"Please input a name for foe number {0}:\n", i);
                string foeName = Console.ReadLine();

                Foe foe = new Foe(foeName);
                allFoes[i - 1] = foe;
            }

            Console.WriteLine("\n\nFinal list of foes:\n");

            foreach (Foe foe in allFoes)
            {
                Console.WriteLine($"Foe {foe.GetName()}, with {foe.GetHealth()} HP and {foe.GetShield()} shield.\n");
            }
        }
    }
}
