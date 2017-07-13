using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchVersion3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite car?");
            string color = Console.ReadLine();

            switch (car)
            {
                case "red":
                    Console.WriteLine("Red is an ok color");
                    break;

                default:
                    Console.WriteLine("We don't understand your answer");
                    break;


            }
            Console.ReadLine();




        }
    }
}
