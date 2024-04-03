using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Equipment
    {
        public string name { get; private set; }
        public int armor { get; private set; }
        public int attack { get; private set; }
        public int health { get; private set; }
        public int mp { get; private set; }
        private int _type;

        public Equipment(string name, int armor, int attack, int health, int mp, int type)
        {
            this.name = name;
            this.armor = armor;
            this.attack = attack;
            this.health = health;
            this.mp = mp;
            this._type = type;
        }

        public int GetArmor()
        {
            return armor;
        }

        public int GetAtk()
        {
            return attack;
        }

        public int GetHealth()
        {
            return health;
        }

        public int GetMP()
        {
            return mp;
        }

        public int GetSlot()
        {
            return _type;
        }
    }
}
