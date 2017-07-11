using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite car?");
            string Car = Console.ReadLine().ToLower();

            if (Car == "mustang")
            {
                Console.WriteLine("I like Mustang's also!");

            }
            else if (Car == "pinto") 
            {
                Console.WriteLine("pinto's are ok also");
            }
            else if (Car == "corvette")

            {
                Console.WriteLine("Those are Nice Too!");
            }
            else
            { Console.WriteLine("We don't understand the car choice?");
            }
            Console.ReadLine();






        }
    }
}
