using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite flavor of ice cream?");
            string flavor = Console.ReadLine().ToLower();

            if (flavor == "vanilla")
            {
                Console.WriteLine("I like vanilla also!");

            }
            else if (flavor == "chocolate")
            {
                Console.WriteLine("chocolate is ok also");
            }
            else if (flavor == "strawberry")

            {
                Console.WriteLine("strawberry is good too!");
            }
            else
            {
                Console.WriteLine("We don't understand your flavor choice?");
            }
            Console.ReadLine();
        }
    }
}
