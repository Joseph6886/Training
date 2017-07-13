using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace SwitchVersion4
{
    class Program
    {
        static void Main(string[] args)
        {

            int foodlike = 0;
                Console.WriteLine("What is your favorite pasta dish? \n 1. Lasagne \n 2. Spaghetti \n 3. Ravioli");
            //foodlike = Convert.ToInt32(ReadLine().ToUpper());
            string foodchoice = Console.ReadLine();
            //int foodchoice = int.Parse(ReadLine());
            int.TryParse(foodchoice, out foodlike);
            //double food = Convert.ToDouble(ReadLine().ToUpper);

            switch (foodlike)

            { case 1:
                Console.WriteLine("Lasagne is fantastic!");
                break;
            }

            ReadLine();



                




        }
    }
}
