using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject1
{

    enum Calculator
    {
        Addition = 1,
        Subtraction,
        Multiply,
        Divide



    }
    class Program

    {
        static void Main(string[] args)
        {
            int Operation;
            Console.WriteLine("Which operation would you like to do? \n 1. Addition \n 2. Subtraction \n 3. Multiply \n 4. Division");
            string number = Console.ReadLine();


            int.TryParse(number, out Operation);

            switch ((Calculator)Operation)
            {
                case Calculator.Addition:
                    Add();
                    break;
                case Calculator.Subtraction:
                    Sub();
                    break;
                case Calculator.Multiply:
                    Mul();
                    break;
                case Calculator.Divide:
                    Div();
                    break;
                default:
                    break;
                    
            }
        }

        public static void Add()
        {

            Console.WriteLine("Addition is fun!, Coding is hard");
            Console.ReadLine();

        }
        public static void Sub()
        {
            Console.WriteLine("Subtraction is fun!, Coding is hard");
            Console.ReadLine();
        }
        public static void Mul()
        {
            Console.WriteLine("Multiplication is fun!, Coding is hard");
            Console.ReadLine();
        }
        public static void Div()
        {
            Console.WriteLine("Division is fun!, Coding is hard");
            Console.ReadLine();

        }
    }
}
        //this is an arguement

        //public static void Add(int val1, int val2)
        //{
        //    Program p = new Program();

        //    int val1;
        //    int val2;
        //    Console.WriteLine("Give me the first number to execute");
        //    string num1 = Console.ReadLine();
        //    int.TryParse(num1, out val1);



            //    }
            //    public static void Sub()
            //    {
            //        Console.WriteLine("Give me a second number to execute");
            //        string num2 = Console.ReadLine();
            //    int.TryParse(num2, out val2);

            //}
            //public static void Mul()
            //{
            //    Console.WriteLine("Give me a third number to execute");
            //    string num3 = Console.ReadLine();
            //    int.TryParse(num3, out val3);

            //}
            //public static void Div()
            //{
            //    Console.WriteLine("Give me a second number to execute");
            //    string num2 = Console.ReadLine();
            //    int.TryParse(num2, out val2);

            //}












            ////These are peramiters
            //public void Multiply(int val1, int val2)
            //    {
            //        int product = val1 * val2;

            //        Console.WriteLine($"The product of {val1} and {val2} is {product}");


            //    }
            //    public void Addition(int val1, int val2)
            //    {
            //        int total = val1 + val2;
            //        Console.WriteLine($"The product of {val1} added to {val2} is {total}");
            //    }
            //    public void Subtraction(int val1, int val2)
            //    {
            //        int answer = val1 - val2;
            //        Console.WriteLine($"The product of {val1} added to {val2} is {answer}");

        
    

    
        
        





        
    

