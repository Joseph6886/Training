using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is an arguement
            Program p = new Program();
            
            int val1;
            int val2;
        
            Console.WriteLine("Give me the first number to execute");
            string num1 = Console.ReadLine();
            int.TryParse(num1, out val1);

            Console.WriteLine("Give me a second number to execute");
            string num2 = Console.ReadLine();
            int.TryParse(num2, out val2);

            p.Multiply(val1, val2);
            p.Addition(val1, val2);
            p.Subtraction(val1, val2);

            Console.ReadLine();


        }
        //These are peramiters
        public void Multiply(int val1, int val2)
        {
            int product = val1 * val2;

            Console.WriteLine($"The product of {val1} and {val2} is {product}");


        }
        public void Addition(int val1, int val2)
        {
            int total = val1 + val2;
            Console.WriteLine($"The product of {val1} added to {val2} is {total}");
        }
        public void Subtraction(int val1, int val2)
        {
            int answer = val1 - val2;
            Console.WriteLine($"The product of {val1} added to {val2} is {answer}");

        }

    }
}
