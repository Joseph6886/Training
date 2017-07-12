using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseVersion4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Kohl's, how much money do you have today?");
            double firstnum = double.Parse(Console.ReadLine());

            if (firstnum < 100 && firstnum >= 75)
            {
                Console.WriteLine("You can purchase anything you like!");
            }
            else if (firstnum <= 74 && firstnum >= 50)
            {
                Console.WriteLine("We have a nice pair of jeans for you");


            }
            else if (firstnum <= 49 && firstnum >= 25)
            {
                Console.WriteLine("You can't get much");

            }
            else if (firstnum <= 24 && firstnum > 0)
            {
                Console.WriteLine("GET OUT!");


            }
            else
            {
                Console.WriteLine("Wow! your rich!!!");
            }

            Console.ReadLine();









        }
    }
}
