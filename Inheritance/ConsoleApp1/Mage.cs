namespace Charbase
{
    public class Mage : Character
    {
        public int spellPower;
        public Mage()
        {
            Console.WriteLine("---> Konstruktor Default Mage<---");
        }
        public Mage(int spellPower, string id, string name, int power, string address) : base(id, name, power, address)
        {
                Console.WriteLine("---> Konstruktor Berparameter Mage<---");
                this.spellPower = spellPower;
        }
        //Display Stat
        public void CharInfo()
        {
            base.BaseCharInfo();
            Console.WriteLine("Bonus spell      =" + spellPower);
            Console.WriteLine("Power Total      =" + (GetBasePower() + spellPower));           
        }
    }
}