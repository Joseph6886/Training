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
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            switch(color)
            {
                case "red":
                    Console.WriteLine("Red is an ok color");
                    break;

                default:
                    Console.WriteLine("We don't understand your answer");
                    break;
                    

            }
            Console.ReadLine();
            
            int foodlike;
            Console.WriteLine("What's your favorite pasta dish \n 1. Lasagne \n 2. Spaghetti \n 3. Ravioli");
            // int foodchoice = Convert.ToInt32(ReadLine().ToUpper());
            string foodchoice = Console.ReadLine();
            // int foodchoice = int.Parse(ReadLine());
            int.TryParse(foodchoice, out foodlike);
            switch (foodlike)
            { case 1:
                    Console.WriteLine("Lasagne is fantastic!!!");
                    break;
                case 2:
                    Write("Spaghetti is delicious");
                    break;
                case 3:
                    Console.Write("Ravioli was invented by Chef Boyardi");
                    break;
                default:
                    Write("That is not a pasta choice!");
                    break; 
                    

                    
                    
            }
            Console.ReadLine();
        }
    }
}
