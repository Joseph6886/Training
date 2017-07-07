using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            //string contentation
            Console.WriteLine("Hello " + name + " How are you today");
            Console.ReadKey();
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine("You are a {0} year old guy", age);
            //variable dropping into place
            Console.WriteLine(" {0} You are a {1} year old guy am I right {2}", name,age, age);
            Console.ReadLine();
            Console.WriteLine("Are you going out tonight");
            string goingOut = Console.ReadLine();
            //string interpolation
            Console.WriteLine($"My name is {name} I am {age} and {goingOut} of coarse");
            Console.ReadKey();







        }
    }
}
