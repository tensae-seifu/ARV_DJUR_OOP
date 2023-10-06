using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    // Define the Dog class, which inherits from the Animals class.
    internal class Dog : Animals
    {
        // Declare a public field to store the dog's attitude.
        public string _Attitude;

        // Constructor for initializing dog properties.
        public Dog(string Name, string Attitude, int Age)
            : base(Name, "Barking", "Omnivor", "indoors", Age)
        {
            this._Attitude = Attitude;
        }

        // Method to get information about the dog's attitude.
        public void GetAttitude()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{_Name} Is very {_Attitude}");
        }
    }

    // Define the Chiwawa class, which inherits from the Dog class.
    class Chiwawa : Dog
    {
        // Declare a public field to store the Chiwawa's size.
        public string _Size;

        // Constructor for initializing Chiwawa properties.
        public Chiwawa(string Name, string Size) : base(Name, "Guffy", 12)
        {
            this._Size = Size;
        }

        // Method to get information about the Chiwawa's size.
        public void GetSize()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{_Name} is a Chiawawa and is very {_Size} in size");
        }
    }

    // Define the Bulldog class, which inherits from the Dog class.
    class Bulldog : Dog
    {
        // Declare a public field to store the Bulldog's strength.
        public string _Strength;

        // Constructor for initializing Bulldog properties.
        public Bulldog(string Name, string Strength) : base(Name, "Agressive", 10)
        {
            this._Strength = Strength;
        }

        // Method to get information about the Bulldog's strength.
        public void GetStrength()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{_Name} is a Bulldog and very {_Strength}");
        }
    }
}