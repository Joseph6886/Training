using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameVersion1
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();
            // Random rnd = new Random();
            Console.WriteLine("Hello world");

            p.Working();
            Talking();
            Playing();
            Running();


            Console.WriteLine(" I'm back in the main method!!!");
            Console.ReadLine();



        }
        public void Working()
        {
            Console.WriteLine("Hey...I'm working over here!!!");

        }
        public static void Talking()
        {
            Console.WriteLine("Talking a lot today");
        }
        public static void Playing()
        {
            Console.WriteLine("Playing in Visual Studio");
        }
        public static void Running()
        {
        Console.WriteLine("Running in place");
        }


    }


}       


  

    
    

