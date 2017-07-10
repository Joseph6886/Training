using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite color?");
            string favColor = Console.ReadLine().ToUpper();

            if (favColor == "RED")
            {
                Console.WriteLine("red is good");
               
            }
            else
            {
                Console.WriteLine("Whaterever");

            }
                Console.ReadLine();

            }

        }
    }

