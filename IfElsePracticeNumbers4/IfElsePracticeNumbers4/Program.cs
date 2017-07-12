using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePracticeNumbers4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            double firstnum = double.Parse(Console.ReadLine());

            if(firstnum > 0 && firstnum < 10)
            { Console.WriteLine("You're just a kid");
            }
            else if (firstnum > 11 && firstnum <20)
            {
                Console.WriteLine("You are in your middle years");


            }
            else if (firstnum > 21 && firstnum < 35)
            {
                Console.WriteLine("You're getting there");

            }
            else if (firstnum > 36 && firstnum <55)
            {
                Console.WriteLine("You have it figured out by now");


            }
            else
            {
                Console.WriteLine("You're in your golden years!!!");
            }

            Console.ReadLine();

        }



    }
}
