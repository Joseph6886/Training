using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice1
{

    enum Movies
    {
        Jaws = 1,
        Goodfellas,
        Heat,
        Scarface,
        Godfather,
        Avatar,
        Inception,
        GetOut

    }

    enum Beers
    {
        Bud = 1,
            Coors,
            Harp,
            Guinness,
            Great_Lakes,

    }
    class Program
    {
        static void Main(string[] args)
        {
            int favMovie;
            Console.WriteLine("Which movie is your favorate \n 1. Jaws \n 2. Goodfellas \n 3. Heat");
            string favorite = Console.ReadLine();
            int.TryParse(favorite, out favMovie);
            switch ((Movies)favMovie)
            {
                case Movies.Jaws:
                    Console.WriteLine("Jaws is a great movie");
                    break;
                case Movies.Goodfellas:
                    Console.WriteLine("Goodfellas...an American classic");
                    break;
                case Movies.Heat:
                    Console.WriteLine("Heat...A Thriller in Miami");
                    break;
                default:
                    Console.WriteLine("That movie did not make our list");
                    break;
            }
                    Console.ReadKey();

        int favbeer;
        Console.WriteLine("Which beer is your favorate \n 1. Bud \n 2. Coors \n 3. Harp");
        string best = Console.ReadLine();
        int.TryParse(best, out favbeer);
        switch ((Beers)favbeer)
        {
            case Beers.Bud:
                Console.WriteLine("Bud is an American Beer");
                break;
            case Beers.Coors:
                Console.WriteLine("Coors is a light golden beer from Colorado");
                break;
            case Beers.Harp:
                Console.WriteLine("Harp is a delicious Irish brew!");
                break;
            default:
                Console.WriteLine("That beer did not make our list");
                break;
        }
            

                    
            Console.WriteLine("Out of the beer switch statement block");
            Console.ReadLine();
                    


            
        }
    }
}
