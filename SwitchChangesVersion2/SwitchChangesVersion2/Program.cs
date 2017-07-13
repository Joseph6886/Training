using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace SwitchChangesVersion2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int City;
            Console.WriteLine("Where would you like to go on your next vacation? \n 1. Orlando FL- Walt Disney World \n 2. New York NYC- Madison Square Garden \n 3. Las Vegas NV- Sin City");
            
            string State = Console.ReadLine();
            
            int.TryParse(State, out City);

            switch (City)
            {
                case 1:
                    Console.WriteLine("Disney World is fun!");
                    break;
                case 2:
                    Write("New York City has the nightlife!");
                    break;
                case 3:
                    Console.Write("Sin City is Trouble!");
                    break;
                default:
                    Write("That is not a valid destination!");
                    break;




            }
            Console.ReadLine();
        }
    }
}
