﻿using System;
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

            Program p = new Program();
            
            int val1;
            int val2;
            Console.WriteLine("Give me the first number to multiply");
            string num1 = Console.ReadLine();
            int.TryParse(num1, out val1);

            Console.WriteLine("Give me a second number to multiply");
            string num2 = Console.ReadLine();
            int.TryParse(num2, out val2);

            p.Multiply(val1, val2);

            Console.ReadLine();


        }

        public void Multiply(int val1, int val2)
        {
            int product = val1 * val2;

            Console.WriteLine($"The product of {val1} and {val2} is {product}");


        }

    }
}
