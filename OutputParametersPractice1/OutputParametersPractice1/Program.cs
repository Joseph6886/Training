﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParametersPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int first = 0, second = 0;
            Console.WriteLine($"the intitial value of first is {first}\n the initial value of second is {second}");
            p.FindValues(out first, out second);
            Console.WriteLine($"the final value of first is {first}\n the final value of second is {second}");
            Console.ReadLine();


        }
        private void FindValues(out int firstNum, out int secondNum)
        {
            Console.WriteLine("Give me a first number to work with");

            string firstVal = Console.ReadLine();

            int.TryParse(firstVal, out firstNum);

            Console.WriteLine("Give me a second number to work with");

            string secondVal = Console.ReadLine();

            int.TryParse(secondVal, out secondNum);

            firstNum = firstNum + secondNum;
            secondNum = (firstNum - secondNum) * secondNum;
            




        }
    }

}
