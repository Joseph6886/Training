using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = {1,5,12,66,27};
            string[] nameArray = { "Nancy Drew", "Columbo", "Hardy Boys" };

            for (int i = 0; i < arrayInt.Length; i++)
            {
                Console.WriteLine("The value of the arreyInt is" + arrayInt[i]);
            }

            Console.WriteLine("We are now out of the loop");

            Console.ReadLine();
            MaxArray(arrayInt);
            Sumarray(arrayInt);
            ListNames(nameArray);

        }

        public static void Sumarray(int [] arrayVals)
        {
            int sumation = arrayVals.Sum();
            Console.WriteLine($"The sum of the array is {sumation}");
            Console.ReadLine();
            

        }

        public static void MaxArray(int [] IntArray)
        {

            int maxVal = IntArray.Max();
            Console.WriteLine($"The maximum value of the array is {maxVal}");
            Console.ReadLine();
        }

        public static void ListNames(string [] Names)
        {
            for(int k = 0; k < Names.Length; k++)
            {
                Console.WriteLine("The names of the ArrayNames array are " + Names[k]);
                
            }
            Console.ReadLine();

        }

    }
}
