using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class DamageCalculator
    {
        public int CalculateDamage(Character attacker, Character defender)
        {
            int damage = (attacker.attack - defender.defense) * -1;

            return damage;
        }
    }
}
