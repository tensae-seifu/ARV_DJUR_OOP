using Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("HERE ARE MY ANIMALS");
            Console.WriteLine("==================\n");

            // Create a Dog object named 'pappy'.

            Dog pappy = new Dog("Scobby", "Friendly", 30);


            // Call various methods to display information about 'pappy'.
            pappy.MakeSound();
            pappy.GetFood();
            pappy.GetHabitat();
            pappy.GetAttitude();
            pappy.GetAge();

            Console.WriteLine("========================");

            // Create a Chiwawa object named 'Marley'.

            Chiwawa Marley = new Chiwawa("Marley", "Small");

            Marley.MakeSound();
            Marley.GetFood();
            Marley.GetHabitat();
            Marley.GetAttitude();
            Marley.GetAge();
            Marley.GetSize();


            Console.WriteLine("========================");


            // Create a Bulldog object named 'max'.

            Bulldog max = new Bulldog("Max", "Strong");


            // Call various methods to display information about 'max'.

            max.MakeSound();
            max.GetFood();
            max.GetHabitat();
            max.GetAttitude();
            max.GetAge();
            max.GetStrength();


            Console.WriteLine("========================");


            Lion simba = new Lion("Simba", "King");


            simba.MakeSound();
            simba.GetFood();
            simba.GetHabitat();
            simba.GetAge();
            simba.GetStatus();

            Console.WriteLine("========================");

            // Create an Elephant object named 'raju'.

            Elephant raju = new Elephant("Raju", "Long trunk");

            // Call various methods to display information about 'raju'.

            raju.MakeSound();
            raju.GetFood();
            raju.GetHabitat();
            raju.GetAge();
            raju.GetTrunksize();



            Console.WriteLine("========================");
        }
    }
}