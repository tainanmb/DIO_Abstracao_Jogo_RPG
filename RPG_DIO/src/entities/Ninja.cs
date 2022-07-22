namespace RPG_DIO.src.entities
{
    public class Ninja : Hero
    {
        private const int maxHP = 574;

        public Ninja(string name, int level, int healthPoints, int magicPoints)
            : base(name, level, healthPoints, magicPoints) { }

        public override void Attack()
        {
            Console.WriteLine("Esse heroi ataca com artes marciais!");
            if (this.HealthPoints < (maxHP * 10) / 100)
            {
                Console.WriteLine(
                    "Sua energia está abaixo de 10%. O ataque pode não funcionar em potência máxima!"
                );
            }
        }
    }
}
