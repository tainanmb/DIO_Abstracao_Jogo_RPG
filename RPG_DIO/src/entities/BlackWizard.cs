namespace RPG_DIO.src.entities
{
    public class BlackWizard : Hero
    {
        private const int maxHP = 385;

        public BlackWizard(string name, int level, int healthPoints, int magicPoints)
            : base(name, level, healthPoints, magicPoints) { }

        public override void Attack()
        {
            Console.WriteLine("Esse heroi ataca com magia negra!");
            if (this.HealthPoints < (maxHP * 10) / 100)
            {
                Console.WriteLine(
                    "Sua energia está abaixo de 10%. O ataque pode não funcionar em potência máxima!"
                );
            }
        }
    }
}
