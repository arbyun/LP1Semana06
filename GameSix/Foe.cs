using System;

namespace GameSix
{
    public class Foe
    {
        private string name;
        private float health;
        private float shield;

        /// <summary> Constructor for the Foe class. Takes in a string to be the new name and sets the health to 100
        /// and shield to 0.</summary>
        /// <param name="newname"> The new name of the enemy</param>
        public Foe(string newname)
        {
            SetName(newname);
            health = 100;
            shield = 0;
        }
        
        public string GetName() => name;

        /// <summary> Takes a string as an argument and sets the name of the foe to that string.        
        /// If there are spaces in the new name, they will be removed.
        /// If no argument is given, or if it's empty, an ArgumentNullException will be thrown.</summary>
        /// <param name="newname"> /// the name of the foe. </param>
        /// <returns> The name of the foe.</returns>
        public string SetName(string newname)
        {
            if (newname.Contains(" "))
            {
                newname = newname.Replace(" ", "");
            }
            else if (newname == "")
            {
                throw new ArgumentNullException(nameof(newname), "The name of the foe can't be empty!");
            }
            
            return name = newname;
        }
        
        public float GetHealth() => health;
        public float GetShield() => shield;

        /// <summary> Takes a float as an argument and subtracts it from the shield. If the shield is less than 0,
        /// then it sets the health to 0.</summary>
        /// <param name="dmg"> /// the amount of damage that the player takes. </param>
        /// <returns> The shield and health.</returns>
        public void TakeDamage(float dmg)
        {
            shield -= dmg;

            if (shield < 0)
            {
                float dmgToTake = -shield;
                shield = 0;
                health -= dmgToTake;
                if (health < 0)
                {
                    health = 0;
                }
            }
        }

    }
}