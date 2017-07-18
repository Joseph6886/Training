using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopVersion1
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "bob";
            string password = "agent";
            Console.WriteLine("What is your user name?");
            string inputname = Console.ReadLine();
            Console.WriteLine(" What is your password?");
            string pw = Console.ReadLine();
            //int x = 5  assigns a value
            //if(x == 5) checking to see if the value equates

            while (inputname != username || pw != password) //"bob")
            {
                Console.WriteLine($"The combination that you entered was not correct");
                Console.WriteLine("Try again!");
                inputname = Console.ReadLine();
                pw = Console.ReadLine();

            }
            Console.WriteLine("That was the correct Username and password...Hooray!");
            Console.ReadLine();









        }
    }
}
