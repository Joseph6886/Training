using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPassingReferenceStrings1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Player 1, What is your name?");
            string MyName1 = Console.ReadLine();

            Console.WriteLine("Player 2, What is your name?");
            string MyName2 = Console.ReadLine();

            Console.WriteLine("Player 3, What is your name?");
            string MyName3 = Console.ReadLine();

            Console.WriteLine("Player 4, What is your name?");
            string MyName4 = Console.ReadLine();

            Console.WriteLine($"In the main method, your name is = {MyName1}");
            AlternateName(MyName1);

            Console.WriteLine($"In the main method the value of x is now {MyName1}");

            Mike(ref MyName2);

            Console.WriteLine($"In the main method the value of exciting x is now {MyName2}");
            George(ref MyName3);
            Console.WriteLine($"The value of z is now {MyName3}");

            Console.ReadLine();




        }


        private static void AlternateName(string Joe)
        {
            Joe = "King of the world";
            Console.WriteLine($"We're in the display value parameter method \n where x = {Joe}");
        }

        private static void Mike(ref string Mike)
        {
            Mike = "Michael Jordan";
            Console.WriteLine($"We're in the very exciting new value method \n where x = {Mike}");


        }


        private static void George(ref string George)
        {
            George = "The Lionhearted";
            Console.WriteLine($"We're in the very exciting new value method \n where x = {George}");


        }

    }
}
