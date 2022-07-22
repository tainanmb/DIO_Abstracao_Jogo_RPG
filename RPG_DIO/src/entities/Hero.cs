namespace RPG_DIO.src.entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        public int MagicPoints { get; set; }

        public Hero(string name, int level, int healthPoints, int magicPoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.MagicPoints = magicPoints;
        }

        public abstract void Attack();

        public override string ToString()
        {
            string hero = "Heroi: " + this.Name;
            hero += "\n" + "Level: " + this.Level;
            hero += "\n" + "HP: " + this.HealthPoints;
            hero += "\n" + "MP: " + this.MagicPoints;
            return hero;
        }
    }
}
