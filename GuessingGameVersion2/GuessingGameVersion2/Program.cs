using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameVersion2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int rNum = rand.Next(1, 6);
            int realNum;


            Console.WriteLine("Enter a number between 1 and 5");
            string numGuess = Console.ReadLine();

            int.TryParse(numGuess, out realNum);
            while (realNum < 0 || realNum > 6)
            

            while(realNum != rNum)
            {
                Console.WriteLine($"Your guess of {numGuess} was not the correct #...\nGuess again");
                numGuess = Console.ReadLine();
                int.TryParse(numGuess, out realNum);

            }
            Console.WriteLine($"Your guess of {rNum} was correct..Hoorey");
            Console.ReadLine();







        }
    }
}
