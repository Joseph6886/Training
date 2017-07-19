using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int randNum = r.Next(1, 11);
            int actualNum;
            int numOfGuesses = 1;

            Console.WriteLine("Guess a number between 1 and 10");
            do
            {
                string numGuess = Console.ReadLine();
                //string first and integer second
                //int.TryParse(numGuess, out actualNum);
                //tryparse converts the string into an integer
                //"!" is a true false statement for "do"
                while (!int.TryParse(numGuess, out actualNum) || actualNum < 1 || actualNum > 10)
                {
                    Console.WriteLine($"Your entry of {numGuess} is crazy \nTry again!");
                    numGuess = Console.ReadLine();
                    //string first and integer second
                    //int.TryParse(numGuess, out actualNum);

                    numOfGuesses++;



                }
                if (randNum == actualNum)
                {
                    Console.WriteLine($"Your Guess of {randNum} was correct \nYou guessed {numOfGuesses} times...You are a winner!!!");
                    Console.ReadLine();
                }
                //the catch all below
                    
                else
                {
                    Console.WriteLine($"Your guess of {actualNum} was not correct...\nGuess again.");
                    numOfGuesses++;


                }
                //Console.ReadLine();


            } while (actualNum != randNum);
        }
    }
}
