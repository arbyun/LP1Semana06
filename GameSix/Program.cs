using System;
using System.Linq;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many foes would you like to create?\n");
            int n = Console.Read();
            Foe[] allFoes = new Foe[n];
            
            Console.WriteLine("\nNow, I will walk you through the creation for each foe.\n\n");

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine($"Creating Foe {i} out of {n}...\n");
                Console.WriteLine($"Please input a name for foe number {i}:\n");
                string foeName = Console.ReadLine();

                Foe foe = new Foe("foeName");
                allFoes.Append(foe);
            }
        }
    }
}
