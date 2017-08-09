using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int mileDriven;
            int gallonsOfGas;
            int mpg;

            Program p = new Program();
            p.NewError();
            p.ArrayError();



            try
            {


                Console.WriteLine("Enter miles driven");
                mileDriven = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter gallons of gas purchased");
                gallonsOfGas = Convert.ToInt32(Console.ReadLine());

                mpg = mileDriven / gallonsOfGas;
                Console.WriteLine($"You are getting {mpg} miles per gallon");
                Console.ReadLine();
            }

            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine("there was a division by zero exception");
            }
            Console.WriteLine("Our Code blew up...but we are still runnin..Yes!");
            Console.ReadLine();


        }
        public void ArrayError()
        {
            try
            {
                int num = 12, denom = 0, result;
                int[] numArray = { 20, 30, 40 };


                //result = num / denom;
                result = numArray[num];
            }
            catch (DivideByZeroException er)
            {
                Console.WriteLine(er.Message);

            }
            catch(IndexOutOfRangeException i )
            {

                Console.WriteLine(i.Message);
            }
            Console.WriteLine("we are still running");
            Console.ReadLine();
        }

        public void NewError()
        {
            try
            {
                int firstNum = 20, secondNum = 0, answer;

                answer = firstNum / secondNum;
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Our code had an error...but we don't know what happened");


            }
            Console.ReadLine();






        }
    }
}
