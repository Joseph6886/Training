using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPracticeVersion2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] North = { "Browns", "Steelers", "Bengals", "Ravens" };
            for (int j = 0; j < North.Length; ++j)
            {
                Array.Sort(North);
                Console.WriteLine("The 2017 standing for the AFC North is " + (North[j]));

            }
            Console.ReadLine();

            int[] nums = new int[4];
            nums[0] = 10;
            nums[1] = 20;
            nums[2] = 30;
            nums[3] = 40;

            for (int n = 0; n < nums.Length; ++n)
            {

                Console.WriteLine("The values of the arrey nums are " + (nums[n]));
            }
            Console.ReadLine();

            char[] letters = { 'v','i','n','c','e' };
            for(int m = 0; m < letters.Length; ++m)
            {
                Console.WriteLine($"The value of the letters array are { (letters[m])}");
            }
            Console.ReadLine();


































        }
       
    }
}
