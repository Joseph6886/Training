using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPracticeApp1
{
    class Car
    {

        public int milage = 60;

        public string color = "Red";

        private string formula = "a + b";


        public int GetMilage()
        {

            return milage;

        }

        public string GetColor()
        {

            return color;

        }
        private string GetEngineFormula()
        {

            return formula;

        }
        public string DisplayEngineFormula()
        {

            return GetEngineFormula();
        }


    }
}
