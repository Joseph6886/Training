using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractice1
{
    class Program
    {
        static void Main(string[] args)
        { //Create an instantance
            Automobile a1 = new Automobile();

            a1.AutoID = 1000;
            a1.Make = "Chevy";
            a1.Model = "Corvette";
            a1.Year = 2009;
            a1.Color = "red";

            Automobile a2 = new Automobile();
            a2.AutoID = 2000;
            a2.Make = "ford";
            a2.Model = "Explorer";
            a2.Year = 2012;
            a2.Color = "black";

            List<Automobile> carlist = new List<Automobile>();

            carlist.Add(a1);
            carlist.Add(a2);

            foreach (Automobile item in carlist)
            {
                Console.WriteLine($"Our Auto ID is {item.AutoID}, made by {item.Make}, in the year {item.Year}, model type of {item.Model}, with the color as {item.Color}" );
            }
            Console.ReadLine();
            






        }
    }
}
