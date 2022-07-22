using RPG_DIO.src.entities;

namespace RPG_DIO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 42, 20, 72);
            Ninja wedge = new Ninja("Wedge", 42, 300, 89);
            WhiteWizard jenica = new WhiteWizard("Jenica", 42, 200, 474);
            BlackWizard topapa = new BlackWizard("Topapa", 42, 23, 611);

            Hero[] heroList = new Hero[4] { arus, wedge, jenica, topapa };

            for (int i = 0; i < heroList.Length; i++)
            {
                Console.WriteLine(heroList[i]);
                heroList[i].Attack();
                Console.WriteLine("");
            }
        }
    }
}
