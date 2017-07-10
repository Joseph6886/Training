using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Application2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your age?");
            //string AgeNumber = Console.ReadLine();

            //Console.WriteLine("What is your street name?");
            //string StreetName = Console.ReadLine();

            //Console.WriteLine("What is your email address");
            //string email = Console.ReadLine();

            //Console.WriteLine($"My age is {AgeNumber}, my street name is {StreetName}, my email address is {email}");
            //    Console.ReadKey();
            Console.WriteLine("What is your favorite Amusement Park?");
            string park = Console.ReadLine();
            Console.WriteLine("What is your favorite ride?");
            string ride = Console.ReadLine();
            Console.WriteLine("How many times have you gone on it?");
            String times = Console.ReadLine();
            Console.WriteLine($"Your favorite Amusement Park is {park},your favorite ride there is {ride}, and you have ridden it {times} times!!!");
            Console.ReadLine();



        }
    }
}
