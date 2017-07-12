using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite sport?");
            string sport = Console.ReadLine().ToLower();

            string favsport = (sport == "hockey" || sport == "football") ? "Great Choice" : "Bad Choice";

            Console.WriteLine(favsport);
            Console.ReadLine();

            Console.WriteLine("What kind of foods do you like");
            string food = Console.ReadLine().ToLower();
            Console.WriteLine("What kind of other foods do you like");
            string sports = Console.ReadLine().ToLower();

            string foodchoice = (food == "chicken" && sports == "shrimp") ? "Good Choice" : "Bad Choice";
            Console.WriteLine(foodchoice);
            Console.WriteLine($"Your first choice was {food}, your second choice was { sports}");
            Console.ReadLine();


        }
    }
}
