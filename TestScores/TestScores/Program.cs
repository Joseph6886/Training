using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int idNum;
            int lowNum = 0;
            int highNum = 100;

            Console.WriteLine("Enter a valid test score");
            string valNum = Console.ReadLine();
            int.TryParse(valNum, out idNum);

            while (idNum < lowNum || idNum > highNum)
            {
                Console.WriteLine($"The score you entered is {valNum}\n" + $"Your score must be between {lowNum} and {highNum} \nTry again");
                valNum = Console.ReadLine();
                int.TryParse(valNum, out idNum);


            }
            Console.WriteLine("This score is valid");
            Console.ReadLine();

            //for (int i = 1; i <= 100; i++)
            //{
            //    bool fizz = i % 3 == 0;
            //    bool buzz = i % 5 == 0;

            //    if (fizz && buzz)
            //        Console.WriteLine("FizzBuzz");
            //    else if (fizz)
            //        Console.WriteLine("Fizz");
            //    else if (buzz)
            //        Console.WriteLine("Buzz");

            //    else
            //        Console.WriteLine(i);
            //    Console.ReadLine();
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("1");
                    }
                    Console.WriteLine();
                    Console.ReadLine();

                }

            }










        }
    }
}
