namespace Charbase
{
    public class Warrior : Character
    {
        public int bonus; //Atribut tambahan warrior
        //konstruktor
        public Warrior()
        {
        Console.WriteLine("---> Konstruktor Default Warrior<---");
        }
        //Konstrukter parameter
        public Warrior(int bonus, string id, string name, int power, string address) : base(id, name, power, address)
        {
                this.bonus = bonus;
                Console.WriteLine("---> Konstruktor Berparameter Warrior<---");
        }
        //Display Stat
        public void CharInfo()
        {
            base.BaseCharInfo();
            Console.WriteLine("Bonus            =" + bonus);
            Console.WriteLine("Power Total      =" + (GetBasePower() + bonus));           
        }
    }
}