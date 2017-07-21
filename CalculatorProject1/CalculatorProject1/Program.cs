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
        static void Main()
        {
            Program p = new Program();


            int Operation;
            Console.WriteLine("Which operation would you like to do? \n 1. Addition \n 2. Subtraction \n 3. Multiply \n 4. Division");
            string number = Console.ReadLine();
            int.TryParse(number, out Operation);

            int val1;
            int val2;

            Console.WriteLine("Give me the first number to execute");
            string num1 = Console.ReadLine();
           int.TryParse(num1, out val1);

            Console.WriteLine("Give me the second number to execute");
            string num2 = Console.ReadLine();

            int.TryParse(num2, out val2);

            switch ((Calculator)Operation)
            {
                case Calculator.Addition:
                    p.Addition(val1, val2);
                    break;
                case Calculator.Subtraction:
                    p.Subtraction(val1, val2);
                    break;
                case Calculator.Multiply:
                    p.Multiply(val1, val2);
                    break;
                case Calculator.Divide:
                    p.Division(val1, val2);
                    break;
                default:
                    break;



            }

            string answer1 = "yes";
            string answer2 = "no";
            Console.WriteLine("Would you like to try again?");
            string input = Console.ReadLine();

            while (input == answer1)
            {
                Console.WriteLine("Ok, Let's begin again!");
                input = Console.ReadLine();
                Main();
            }
            while (input == answer2)
            {
                Console.WriteLine("I'm glad that we have answered your question, have a great weekend");
                input = Console.ReadLine();

            }
        }

        public void Multiply(int val1, int val2)
        {
            int product = val1 * val2;
            Console.WriteLine($"The product of {val1} and {val2} is {product}");
            Console.WriteLine("You have reached the end of the multiply method");
            Console.ReadLine();
            
        }

        public void Addition(int val1, int val2)
        {
            int total = val1 + val2;
            Console.WriteLine($"The product of {val1} added to {val2} is {total}");
            Console.WriteLine("You have reached the end of the addition method");
            Console.ReadLine();
            
        }

        public void Subtraction(int val1, int val2)
        {
            int answer = val1 - val2;
            Console.WriteLine($"The product of {val1} added to {val2} is {answer}");
            Console.WriteLine("You have reached the end of the subtraction method");
            Console.ReadLine();
            
           
        }    
        public void Division(int val1, int val2)
        {
            int answer = val1 / val2;
            Console.WriteLine($"The product of {val1} added to {val2} is {answer}");
            Console.WriteLine("You have reached the end of the division method");
            Console.ReadLine();
            

        }
    }
}



































//        public static void Add()
//        {

//            Console.WriteLine("Addition is fun!, Coding is hard");
//            Console.ReadLine();

//        }
//        public static void Sub()
//        {
//            Console.WriteLine("Subtraction is fun!, Coding is hard");
//            Console.ReadLine();
//        }
//        public static void Mul()
//        {
//            Console.WriteLine("Multiplication is fun!, Coding is hard");
//            Console.ReadLine();
//        }
//        public static void Div()
//        {
//            Console.WriteLine("Division is fun!, Coding is hard");
//            Console.ReadLine();

//        }
//    }
//}
//this is an arguement

//public static void Add(int val1, int val2)
//{




////    }
//public static void Sub()
//{
//    Console.WriteLine("Give me a second number to execute");
//    string num2 = Console.ReadLine();


//}
//public void Mul()
//{
//    Console.WriteLine("Give me a third number to execute");
//    string num3 = Console.ReadLine();

//}

//            //}
//            //public static void Div()
//            //{
//            //    Console.WriteLine("Give me a second number to execute");
//            //    string num2 = Console.ReadLine();
//            //    int.TryParse(num2, out val2);

////}












////These are peramiters
















