using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Inventory
    {
        public int _inventoryLevel { get; private set; } = 1;
        public List<Consumables> consumableInventory { get; private set; } = [];
        public List<Equipment> equipmentInventory { get; private set; } = [];

        public void AddInventory(Consumables consumable)
        {
            consumableInventory.Add(consumable);

            if (consumableInventory.Count > _inventoryLevel*10)
            {
                consumableInventory.Remove(DestroyConsumable());

            }
        }

        internal Consumables DestroyConsumable()
        {
            for (var i = 0; i < consumableInventory.Count; i++)
            {
                Console.WriteLine($"{i} : {consumableInventory[i]}");

            }
            Console.WriteLine("Inventory is full! Please choose the number on the item to discard:");
            int index = -1;
            
            while (true)
            {
                string? userInput = Console.ReadLine();
                try
                {
                    index = int.Parse(userInput);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid answer. Please choose a valid number on" +
                        "the item to delete");
                }

            }
            Console.WriteLine($"You have chosen {index}: {consumableInventory[index].name}");

            return consumableInventory[index];
        }

        public void AddEquipment(Equipment equipment)
        {
            equipmentInventory.Add(equipment);

            if (equipmentInventory.Count > _inventoryLevel * 10)
            {
                equipmentInventory.Remove(DestroyEquipment());

            }
        }

        internal Equipment DestroyEquipment()
        {
            for (var i = 0; i < equipmentInventory.Count; i++)
            {
                Console.WriteLine($"{i} : {equipmentInventory[i]}");

            }
            Console.WriteLine("Inventory is full! Please choose the number on the item to discard:");
            int index = -1;

            while (true)
            {
                string? userInput = Console.ReadLine();
                try
                {
                    index = int.Parse(userInput);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid answer. Please choose a valid number on" +
                        "the item to delete");
                }

            }
            Console.WriteLine($"You have chosen {index}: {equipmentInventory[index].name}");

            return equipmentInventory[index];
        }
    }
}
