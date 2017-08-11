using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingproject3
{
    public class ApprenticeAccessors: MasterAccessors
    {
        //inherentence from master

        //creating an instance of the apprentice class




        public void Display()
        {
            ApprenticeAccessors a1 = new ApprenticeAccessors
            {
                SaleItem = 1000,
                name = "Peter Parker",
                address = "2525 Hero Dr."




            };

            ApprenticeAccessors a2 = new ApprenticeAccessors
            {
                ID = 1002,
                name = "Thor",
                address = "Asgard Dr."

            };

            List<ApprenticeAccessors> heros = new List<ApprenticeAccessors>();

            heros.Add(a1);
            heros.Add(a2);

            foreach (var item in heros)
            {

                Console.WriteLine($"I am hero # {item.ID} and my name is {item.name} and my address is {item.address}");




            }  
         }           
     }               
 }                   














                  
            