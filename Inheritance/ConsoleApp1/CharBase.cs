using System;

namespace Charbase
{
    public class Character
    {
        //Private attributes
        private string ?characterID;
        private string ?name;
        private int basepower;
        private string ?address;
        //Konstruktor default
        public Character()
        {
            Console.WriteLine("---> Konstruktor Default <---");
        }
        //Konstruktor berparameter
        public Character(string id, string name, int power, string address)
        {
            Console.WriteLine("--->Konstruktor berparameter Character<---");
            this.characterID = id;
            this.name = name;
            this.basepower = power;
            this.address = address;
        }
        //penampilan data
        public void BaseCharInfo()
        {
            Console.WriteLine("ID       =" + characterID);
            Console.WriteLine("Name     =" + name);
            Console.WriteLine("Power    =" + basepower);
            Console.WriteLine("Address  =" + address);
        }    
        //Getter Attribute untuk subclass
        public int GetBasePower()
        {
            return basepower;
        }
        }
}
