using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPassingReferenceString2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("player 1..what is your name??");
            String player1 = Console.ReadLine();
            NameChange(player1);
            Console.WriteLine($"in the main method...the name of player 1 is {player1}");
            NameTransform(ref player1);
            Console.WriteLine($"Inside of the very, very main method the value of player 1 is {player1}");


            Console.ReadLine();



        }

        public static void NameChange(string OrigPlayer1)


        {
            OrigPlayer1 = "new player 1";
            Console.WriteLine($"Inside of the name change method, the name of player 1 \n is {OrigPlayer1}");
        }

        


        public static void NameTransform(ref string player1)
        {
            player1 = "I am the king of the world";
            Console.WriteLine($"Today {player1}");


        }

    }
}   

