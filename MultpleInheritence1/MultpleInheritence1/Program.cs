﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extra;

namespace MultpleInheritence1
{
    class Program
    {
        static void Main(string[] args)
        {

            Apprentice a = new Apprentice();

            a.Display();

            Console.ReadLine();
            Durango d = new Durango();
            int total;

            total = d.PerformAddition(5,10);

            Console.WriteLine(total);
            Special();

            Console.ReadLine();



        }
        public static void Special()
        {
            int total2;
            Durango dur = new Durango();
            dur.Boxer();

            total2 =dur.PerformAddition(20, 200);

            Console.WriteLine(total2);
            

        }

    
    }
}
