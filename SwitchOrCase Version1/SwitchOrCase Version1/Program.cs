using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 
namespace SwitchOrCase_Version1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite car?");
            string car = Console.ReadLine().ToLower();

            switch(car)
            {
                case "mustang":
                    Console.WriteLine("Mustang's are sharp!");
                    break;
                case "corvette":
                    Console.WriteLine("Corvette's are fast!");
                    break;
                case "pinto":
                    Console.WriteLine("Pinto's are junk!");
                    break;
                default:
                    Console.WriteLine("That car is a lemon!");
                    break;
                    

            }
            Console.ReadLine();
            
            
        }
    }
}
