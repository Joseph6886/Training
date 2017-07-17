using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPracticeVersion1
{
    class Program
    {
        static void Main(string[] args)


        {
            //int i = 0;
            //i < 10;
            //i++;
            //arreys
            //arrey of fixed size
            //arreys sizes cannot be changed once created
            // arreys are 0 based
            int[] numbers = { 2, 4, 88, 11, 55, 00, 165 };
            string[] stars = { "Beyonce", "Rianna", "Janet Jackson", "Madonna" };

            for (int i = 0; i < 10; i++)
            {


                Console.WriteLine($"The value of i is { i}");

            }
            
            Console.ReadLine();


            for (int k = 0; k < stars.Length; ++k)
            {
                Console.WriteLine($"The value of i is {k}");


                //Console.WriteLine("The stars are " + (stars[k]));

            }
            Console.ReadLine();
            for (int f = 0; f < numbers.Length; ++f)
                
            {
                Console.WriteLine("The Stars are " + (numbers[f]));
            }
            Console.ReadLine();

            for (int d = 0;d < numbers.Length; ++d )
            {


                Array.Reverse(numbers);
                Console.WriteLine(numbers[d]);
            }
            Console.ReadLine();
        }
    }
}
