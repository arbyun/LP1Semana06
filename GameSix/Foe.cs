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
    }
}