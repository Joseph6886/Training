using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            football fb1 = new football();
            fb1.TeamID = 1000;
            fb1.TeamName = "Browns";
            fb1.Division = "North";
            fb1.Conference = "AFC";
            fb1.NetWorth = 1000000;

            

            football fb2 = new football();
            fb2.TeamID = 2000;
            fb2.TeamName = "Colts";
            fb2.Division = "South";
            fb2.Conference = "AFC";
            fb2.NetWorth = 2000000;


        }
    }
}
