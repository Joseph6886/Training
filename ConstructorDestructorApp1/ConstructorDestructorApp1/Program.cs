using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDestructorApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor pr = new Professor("Charles", "Xavier");
            pr.GoodPeople();
            Professor sn = new Professor(1001, 5000);
            sn.ShowNumbers();

            Console.ReadLine();


        }
    }
}
