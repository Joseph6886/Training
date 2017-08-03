using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject2
{
    class Program
    {
        public class Account
        {
            public double balance;
            public Account()
            {
                balance = 1000.00;
                Console.WriteLine("Current balance is $1000.00");
            }
            public double deposit()
            {
                //double NewBalance;
                double deposit;
                Console.WriteLine("Please enter amount to deposit");
                string number2 = Console.ReadLine();
                double.TryParse(number2, out deposit);
                //NewBalance = balance + deposit;
                //balance = NewBalance;
                ////balance = balance + deposit;
                balance += deposit;
                return balance;
            }
            public double withdrawel()
            {
                double NewBalance;
                double withdrawel;

                Console.WriteLine("Please enter amount to withdraw");
                string number = Console.ReadLine();
                double.TryParse(number, out withdrawel);
                NewBalance = balance - withdrawel;
                balance -= withdrawel;
                return balance;
            }
            

        }

        static void Main(string[] args)
        {
            double NewBalance;
            string balance;
            Account bank = new Account();
            do
            {
        
                Console.WriteLine("Press d for deposit, or press w for withdrawel, or n to exit");

                balance = Console.ReadLine();

                if (balance == "d")
                {
                    NewBalance = bank.deposit();
                    Console.WriteLine("Your new balance is {0}", NewBalance);

                }
                if (balance == "w")
                {
                    NewBalance = bank.withdrawel();
                    Console.WriteLine("Your new balance is {0}", NewBalance);
                }

            } while (balance != "n");
            Console.ReadLine();
        }
    }
}
