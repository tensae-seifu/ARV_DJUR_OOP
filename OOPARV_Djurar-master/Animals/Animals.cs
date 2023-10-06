// Include the djurar namespace.
using Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    // Define the Animals class.
    internal class Animals
    {
        // Declare public fields to store animal properties.
        public string _Name;    // Name of the animal.
        public string _Sound;   // Sound the animal makes.
        public string _Food;    // Type of food the animal eats.
        public string _Habitat; // Habitat where the animal lives.
        public int _Age;        // Age of the animal.

        // Constructor for initializing animal properties.
        public Animals(string Name, string Sound, string Food, string Habitat, int Age)
        {
            this._Name = Name;
            this._Sound = Sound;
            this._Food = Food;
            this._Habitat = Habitat;
            this._Age = Age;
        }

      

        // Method to make the animal sound.
        public void MakeSound()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{_Name} has a {_Sound} sound");
        }

        // Method to get information about the animal's food.
        public void GetFood()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{_Name} is {_Food}");
        }

        // Method to get information about the animal's habitat.
        public void GetHabitat()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{_Name} Lives {_Habitat}");
        }

        // Method to get information about the animal's age.
        public void GetAge()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{_Name} has a maximum life expectancy of {_Age} Years");
        }
    }
}