namespace GameSix
{
    public class Foe
    {
        private string name;
        private float health;
        private float shield;

        /// <summary> Constructor for the Foe class. Takes in a string name and sets the health to 100
        /// and shield to 0.</summary>
        /// <param name="name"> The name of the enemy</param>
        public Foe(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }
        
        public string GetName() => name;

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