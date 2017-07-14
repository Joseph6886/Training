using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice2
{

    enum Burger
    {
Whopper = 1,
BigMac,
Single



    }
    class Program
    {
        static void Main(string[] args)
        {
            int BChoice;
            Console.WriteLine("Which burger is your favorite \n 1. Whopper \n 2. BigMac \n 3. Wendy's single");
            string sandwich = Console.ReadLine();

           
            int.TryParse(sandwich, out BChoice);

            switch ((Burger)BChoice)
            {
                case Burger.Whopper:
                    BK();
                    break;
                case Burger.BigMac:
                    MAC();
                    break;
                case Burger.Single:
                    Wendys();
                    break;
                default:
                    break;

            }

            Console.WriteLine("Out of burger switch");
            Console.ReadLine();   

        }

        public static void Wendys()
        {

            Console.WriteLine("Wendy's Burgers are great!");
            Console.ReadLine();

        }
        public static void BK()
        {
            Console.WriteLine("Burger King is Awesome!");
            Console.ReadLine();
        }
        public static void MAC()
        {
            Console.WriteLine("McDonald's is addictive!");
            Console.ReadLine();
        }
    }
}
