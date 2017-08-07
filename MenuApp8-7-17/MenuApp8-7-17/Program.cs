using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuApp8_7_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuisine sand1 = new Cuisine();

            sand1.HamAndCheese = "Ham and Cheese Sub";
            sand1.Italian = "Italian Sub";
            sand1.Meatball = "Meatball Sub";
            sand1.Pastrami = "Pastrami Sub";
            sand1.TurkeyAndSwiss = "Turkey and Swiss Cheese Sub";
            sand1.SandwichID = 1;

            Cuisine sand2 = new Cuisine();

            sand2.HamAndCheese = "Mustard";
            sand2.Italian = "Ketchup";
            sand2.Meatball = "Relish";
            sand2.Pastrami = "onions";
            sand2.TurkeyAndSwiss = "mayo";
            sand2.SandwichID = 2;



            List<Cuisine> sandList = new List<Cuisine>();

            sandList.Add(sand1);
            sandList.Add(sand2);

            foreach (Cuisine item in sandList)
            {
                Console.WriteLine($"Our first sandwich is {item.HamAndCheese}, our second sanwhich is {item.Italian}, our third sandwich is {item.Meatball}, our forth sandwich is {item.Pastrami}, and our last sandwich is {item.TurkeyAndSwiss}, and it is order number {item.SandwichID}" );


            }
            Console.ReadLine();
            foreach (Cuisine item in sandList)
            {
                if (item == sand1) 
                {
                    Console.WriteLine("Contains Pastrami Sandwich");
                }

                Console.ReadLine();
            }


    }
    }
}
