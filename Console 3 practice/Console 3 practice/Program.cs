using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_3_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite meal?");
            string meal = Console.ReadLine();
            Console.WriteLine("What is your favorite ice cream?");
            string icecream = Console.ReadLine();
            Console.WriteLine("How many scoops do you get?");
            String scoops = Console.ReadLine();
            Console.WriteLine($"Your favorite meal is {meal},your favorite ice cream is {icecream}, and you like this many scoops: {scoops}!");
            Console.ReadLine();
        }
    }
}
