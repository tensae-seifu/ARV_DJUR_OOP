using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Lion : Animals
    {
        public string _Status;

        public Lion(string Name, string Status) : base(Name, "Roaring", "Carnivore", "in the Jungel", 40)

        {
            this._Status = Status;
        }

        public void GetStatus()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{_Name} is the {_Status} of the Jungel");
        }
    }
}