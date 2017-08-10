using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultpleInheritence1
{//inherentence from master
    public class Apprentice: Master
    {//creating an instance of the apprentice class
        

        
        
        public void Display()
        {
            Apprentice a1 = new Apprentice
            {
                ID = 1000,
                name = "Peter Parker",
                address = "2525 Hero Dr."




            };

            Apprentice a2 = new Apprentice
            {
                ID = 1002,
                name = "Thor",
                address = "Asgard Dr."

            };

            List<Apprentice> heros = new List<Apprentice>();

            heros.Add(a1);
            heros.Add(a2);

            foreach (var item in heros)
            {

                Console.WriteLine($"I am hero # {item.ID} and my name is {item.name} and my address is {item.address}");

                

            }
            
        }
        
        



    }

    
}
