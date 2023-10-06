using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    // Define the Elephant class, which inherits from the Animals class.
    internal class Elephant : Animals
    {
        // Declare a public field to store information about the elephant's trunk.
        public string _Trunk;

        // Constructor for initializing elephant properties.
        public Elephant(string Name, string Trunk) : base(Name, "Trumpet", "Omnivor", " in Savana", 25)
        {
            this._Trunk = Trunk;
        }

        // Method to get information about the elephant's trunk size.
        public void GetTrunksize()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{_Name} has a very {_Trunk}");

        }
    }
}