using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopePractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 1;
            int number2 = 2;

            int sum = number1 * number2;
            Console.WriteLine($"The {number1} * {number2} = {sum}");
            Console.WriteLine("We are at the bottom of the main method");
            Console.ReadKey();
            
            Display();
            Printing();
            Display();
        }
        public static void Printing()
        {

            Console.WriteLine("This is great");
            Console.WriteLine("We are at the bottom of the printing method");
            Console.ReadLine();

        }

        public static void Display()
        {
            Console.WriteLine("Today is Friday!  Thank God!");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();


        }
        public static void Multiple()
        {


        }
    
    }
    public class start
    {


    }
}
