using System.IO.Compression;

namespace Charbase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Inheritance===");

            Console.WriteLine("Objek Warrior (dengan parameter)");
            Warrior warrior = new Warrior(50, "W-001", "inoo", 100, "Monestry");
            warrior.CharInfo();
            
            Console.WriteLine("Objek Mage (dengan parameter)");
            Mage mage = new Mage(80, "M-002", "Mioo", 80, "Brome");
            mage.CharInfo();

            Console.WriteLine("Objek ArchMage (dengan parameter)");
            ArchMage archMage = new ArchMage(120, 80, "AM-001", "Binoo", 90, "Brome");
            archMage.CharInfo();

            Console.WriteLine("Objek Warrior (dengan parameter)");
            Warrior warriorDefault = new Warrior();
            warriorDefault.CharInfo();

            Console.ReadKey();
        }
    }
}