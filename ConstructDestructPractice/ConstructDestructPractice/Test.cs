using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructDestructPractice
{
    class Test
    {
        private double length = 5;

        
        //this is a constructor below...same name as the class itself
        public Test(double l)
        {

            double x = l + 5;
            Console.WriteLine("This is the constructor talking now!!!");


        }
        //the tilda denotes the destructor below!!!
        ~Test()
        {

            System.Diagnostics.Trace.WriteLine("We are cleaning up my mess now");
        }


    }
}
