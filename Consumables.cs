using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Consumables
    {
        private int _type;
        public string name { get; private set; }
        public int effect { get; private set; }

        public Consumables(int type, string name, int effect = 0)
        {
            this._type = type;
            this.name = name;
            this.effect = effect;
        }

        public string GetName()
        {
            return name;
        }
    }
}
