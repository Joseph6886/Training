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

            string favsport = (sport == "Hockey" || sport == "football") ? "Great Choice" : "Bad Choice";

            Console.WriteLine(favsport);
            Console.ReadLine();



        }
    }
}
