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
                Console.WriteLine($"Please input a name for foe number {i}:\n");
                string foeName = Console.ReadLine();

                Foe foe = new Foe(foeName);
                allFoes[i - 1] = foe;
            }

            Console.WriteLine("\n\nFinal list of foes:\n");

            foreach (Foe foe in allFoes)
            {
                Console.WriteLine($"Foe {foe.GetName()}, with {foe.GetHealth()} HP and {foe.GetShield()} shield.\n");
            };

            Testing();
        }

        /// <summary> Simple function that tests the functionality of the Foe class.        
        /// It creates two instances of Foe, and then uses them to test all methods in the class.</summary>
        private static void Testing()
        {
            Foe kindred = new Foe("Kindred");
            Foe ivern = new Foe("Ivern");
            
            Console.WriteLine($"\n\n\nFoe {kindred.GetName()} has {kindred.GetHealth()} HP and {kindred.GetShield()} shield.\n");
            
            kindred.PickupPowerUp(PowerUp.Health, 50);
            
            Console.WriteLine($"She picks up a health power up! Now she has {kindred.GetHealth()} HP.\n");
            
            kindred.TakeDamage(100);
            
            Console.WriteLine($"{kindred.GetName()} takes 100 damage. Thanks to the powerup, she remains with " +
                              $"{kindred.GetHealth()} HP!");
            
            Console.WriteLine($"\n\nFoe {ivern.GetName()} has {ivern.GetHealth()} HP and {ivern.GetShield()} shield.\n");
            
            ivern.PickupPowerUp(PowerUp.Shield, 200);
            
            Console.WriteLine($"He picks up a shield power up! Now he has {ivern.GetShield()} shield.\n");
            
            ivern.TakeDamage(150);
            
            Console.WriteLine($"{ivern.GetName()} takes 150 damage! He tanks it, remaining with {ivern.GetShield()} of " +
                              $"his shield. His remaining health is {ivern.GetHealth()}.");
        }
    }
}
