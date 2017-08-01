using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentJuly31
{

    class RectangleTester




    {
        static void Main(string[] args)
        {
           
            Recantagle r = new Recantagle();
            r.SetHeight(5);
            r.SetWidth(7);
            Console.WriteLine($"Total Area {r.GetArea()}");
            Console.ReadLine();

        }
    }
    //Base class shape below
    class Shape
    {
        protected int height;
        protected int width;

        public void SetWidth(int w)
        {
            width = w;

        }
        public void SetHeight(int h)
        {

            height = h;
        }

    }
    //derived class below names rectangle

    class Recantagle : Shape
    {
        public int GetArea()
        {


            return (width * height);
        }
    }

        

   
    








}
