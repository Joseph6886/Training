using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritencePractice1
{

    public class Employee
    {
        //Base Class
        public string FirstName;
        public string LastName;
        public int EmployeeId;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine($"My first name is {FirstName} and my last name is {LastName}");

        }



    }















    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee ft = new FullTimeEmployee();
            ft.


        }
    }

    public class FullTimeEmployee : Employee
    {

        public double Salary;
        public double FullTimeId;
    }


}
