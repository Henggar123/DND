using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DNDCharacterSheet{
    internal class Program{
        static void Main(string[] args){
            Console.WriteLine("Hello World");
            int index = 0;
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
        }
    }
}