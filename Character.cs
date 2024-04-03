using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Character{
        public string name { get; private set; }
        public int level { get; private set; }
        public int attack {  get; private set; }
        public int defense { get; private set; }
        public int maxHP { get; private set; }
        public int maxMP { get; private set; }
        public int currentHP { get; private set; }
        public int currentMP { get; private set; }
        public Equipment? slot1 { get; private set; } = null;
        public Equipment? slot2 { get; private set; } = null;
        public Equipment? slot3 { get; private set; } = null;
        public Equipment? weapon { get; private set; } = null;
        public Inventory inventory { get; private set; } = new Inventory();

        public Character (string name)
        { 
            this.name = name;
            this.level = 1;
            this.defense = 5;
            this.attack = 10;
            this.maxMP = 25;
            this.currentHP = maxHP;
            this.maxMP = 10;
            this.currentMP = maxMP;
        }

        public int CalculateDefense()
        {
            int slot1Armor = slot1 != null ? slot1.GetArmor() : 0;
            int slot2Armor = slot2 != null ? slot2.GetArmor() : 0;
            int slot3Armor = slot3 != null ? slot3.GetArmor() : 0;
            int weaponArmor = weapon != null ? weapon.GetArmor() : 0;

            int armor = defense + slot1Armor + slot2Armor + slot3Armor + weaponArmor;

            return armor;
        }

        public int CalculateAttack()
        {
            int slot1ATK = slot1 != null ? slot1.GetAtk() : 0;
            int slot2ATK = slot2 != null ? slot2.GetAtk() : 0;
            int slot3ATK = slot3 != null ? slot3.GetAtk() : 0;
            int weaponATK= weapon != null ? weapon.GetAtk() : 0;

            int atk = attack + slot1ATK + slot2ATK + slot3ATK + weaponATK;

            return atk;
        }

        public int CalculateMaxHP()
        {
            int slot1HP = slot1 != null ? slot1.GetHealth() : 0;
            int slot2HP = slot2 != null ? slot2.GetHealth() : 0;
            int slot3HP = slot3 != null ? slot3.GetHealth() : 0;
            int weaponHP = weapon != null ? weapon.GetHealth() : 0;

            int health = maxHP + slot1HP + slot2HP + slot3HP + weaponHP;

            return health;
        }

        public int CalculateMaxMP()
        {
            int slot1MP = slot1 != null ? slot1.GetMP() : 0;
            int slot2MP = slot2 != null ? slot2.GetMP() : 0;
            int slot3MP = slot3 != null ? slot3.GetMP() : 0;
            int weaponMP = weapon != null ? weapon.GetMP() : 0;

            int mp = maxMP + slot1MP + slot2MP + slot3MP + weaponMP;

            return mp;
        }

        public void UpdateCurrenthp(int damage)
        {
            currentHP += damage;
        }

        public void UpdateCurrentMP(int value)
        {
            currentMP += value;
        }

        public void EquipNewGear(Equipment gear)
        {
            int type = gear.GetSlot();
            switch (type)
            {
                case 1:
                    if (this.slot1 != null)
                    {
                        inventory.AddEquipment(this.slot1);
                    }
                    this.slot1 = gear;
                    break;
                case 2:
                    if (this.slot2 != null)
                    {
                        inventory.AddEquipment(this.slot2);
                    }
                    this.slot2 = gear;
                    break;
                case 3:
                    if (this.slot3 != null)
                    {
                        inventory.AddEquipment(this.slot3);
                    }
                    this.slot3 = gear;
                    break;
                default:
                    if (this.weapon != null)
                    {
                        inventory.AddEquipment(this.weapon);
                    }
                    this.weapon = gear;
                    break;
            }

            UpdateStats();
        }

        public void UpdateStats()
        {
            CalculateAttack();
            CalculateDefense();
            CalculateMaxHP();
            CalculateMaxMP();
        }
    }
    
}
