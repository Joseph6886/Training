using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice2
{
    class Program
    {
        public interface IThink
        {
            void Football();

            void Baseball();


        }

        public interface IDo
        {

            void Basketball();
        }

        public class Sports : IThink, IDo
        {



            public void Football()
            {

                Console.WriteLine("The Browns will be 8-8 this year");
            }

            public void Baseball()
            {

                Console.WriteLine("The Indians lost last night");
            }

            public void Basketball()
            {
                Console.WriteLine("The Cavs are going to trade Kyrie");

            }

            
                
        }
            



        static void Main(string[] args)
        {
        Sports s = new Sports();
        s.Football();
        s.Baseball();
        s.Basketball();

        Console.ReadLine();



                   
        }
    }
}
