namespace Charbase
{
    public class ArchMage : Mage
    {
        public int AncientKnowledge;
        public ArchMage()
        {
            Console.WriteLine("---> Konstruktor Default ArchMage<---");
        }
        public ArchMage(int AncientKnowledge,int spellPower, string id, string name, int power, string address) : base(spellPower, id, name, power, address)
        {
                Console.WriteLine("---> Konstruktor Berparameter ArchMage<---");
                this.AncientKnowledge = AncientKnowledge;
        }
        //Display Stat
        public new void CharInfo()
        {
            base.CharInfo();
            Console.WriteLine("Bonus Ancient Knowledge      =" + AncientKnowledge);
            Console.WriteLine("Power Total      =" + (GetBasePower() + spellPower + AncientKnowledge));           
        }
    }
}