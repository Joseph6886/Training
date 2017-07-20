using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice1
{
    class Restaurants
    {
        public static void FamousDaves()
        {//these are instances that we create
            Fashion fash = new Fashion();
            Program p = new Program();
            Restaurants r = new Restaurants();
            //calling instances: Fashion, restaurants, etc.

            fash.Pants();
            fash.Shirts();
            r.Chipotle();

        }
        public void Chipotle()
        {
            Console.WriteLine("We make burritos");

        }
        public void Benihana()
        {
            Console.WriteLine("We cook the food right in front of you");

        }



}
}
