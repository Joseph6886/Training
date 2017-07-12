using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePracticeNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a first number");
            int number1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Give me a second number");
            int number2 = int.Parse(Console.ReadLine());
            

            if (number1 > number2)
            {
                Console.WriteLine($"Your Number {number1} is greater than {number2}");
            }
            else if (number1 < number2)
            {
                Console.WriteLine($"Your first number {number1} is less than your second numner {number2}");
            }
            else
            {
                Console.WriteLine($"Your first number {number1} is equal to your second number of {number2}");
            }
            Console.ReadKey();



        }
    }
}
