using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp8_7_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Shoes shoe1 = new Shoes();

            shoe1.Store = "Sandels";
            shoe1.Online = "Pumps";
            shoe1.Mail = "Heals";
            shoe1.PostOffice = false;
            shoe1.Order = 1;

            Shoes shoe2 = new Shoes();

            
            shoe2.Store = "Flip-Flops";
            shoe2.Online = "dress shoes";
            shoe2.Mail = "loafers";
            shoe2.PostOffice = false;
            shoe2.Order = 2;

            Shoes shoe3 = new Shoes();


            shoe3.Store = "boat shoes";
            shoe3.Online = "slillettos";
            shoe3.Mail = "beach shoes";
            shoe3.PostOffice = false;
            shoe3.Order = 3;

            Shoes shoe4 = new Shoes();


            shoe4.Store = "cowboy boots";
            shoe4.Online = "birthday shoes";
            shoe4.Mail = "bare feet";
            shoe4.PostOffice = false;
            shoe4.Order = 4;

            Shoes shoe5 = new Shoes();


            shoe5.Store = "nike air2";
            shoe5.Online = "nike high tops";
            shoe5.Mail = "nike flats";
            shoe5.PostOffice = true;
            shoe5.Order = 5;

            List<Shoes> shoeList = new List<Shoes>();

            shoeList.Add(shoe1);
            shoeList.Add(shoe2);
            shoeList.Add(shoe3);
            shoeList.Add(shoe4);
            shoeList.Add(shoe5);

            foreach (Shoes item in shoeList)
            {
                Console.WriteLine($"Our first shoe is {item.Store}, our second shoe is {item.Online}, our third shoe is {item.Mail}, our forth shoe is {item.PostOffice}, and our last shoe is {item.Order}");


            }
            Console.ReadLine();
            foreach (Shoes item in shoeList)
            {
                if (item.Store == "nike air2")
                {
                    Console.WriteLine($"Contains {item.Store}");
                }


            }
            Console.ReadLine();





        }
    }
}
