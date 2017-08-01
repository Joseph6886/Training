using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPracticeApp3
{
    class Program
    {
        static void Main(string[] args)
        {


            ScienceFiction Awesome = new ScienceFiction();


            int hell;
            string van;

            van = Awesome.Film();
            Console.WriteLine(van);


            hell = Awesome.Leo();
            Console.WriteLine (hell);
            Console.ReadLine();
        }
    }
}
