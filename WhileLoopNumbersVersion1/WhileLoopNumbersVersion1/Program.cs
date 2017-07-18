using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopNumbersVersion1
{
    class Program
    {
        static void Main(string[] args)
        {

            int idNum;
            int lowNum = 1000;
            int highNum = 2000;

            Console.WriteLine("Enter a valid ID Number");
            string valNum = Console.ReadLine();
            int.TryParse(valNum, out idNum);

            while (idNum < lowNum || idNum > highNum)
            {
                Console.WriteLine($"The ID Number you entered is {valNum}\n" + $"Your ID number must be between {lowNum} and {highNum} \nTry again");

                valNum = Console.ReadLine();
                int.TryParse(valNum, out idNum);

                
            }
            Console.WriteLine("The id number that you entered is valid");
            Console.ReadKey();







        }
    }
}
