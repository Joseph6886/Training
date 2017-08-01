using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPracticeApp3
{
    abstract class Movie
    {
        public abstract string Film();



    }
    class ScienceFiction : Movie
    {
        public int dream = 4;
        private int levels = 5;
        public override string Film()
        {
            string plot= "How many levels are inside the dream?";
            return plot;

        }
    private int secret()
    {
        dream *= levels;
        return dream;

    }

    public int Leo()
    {
        return secret();

    }

}

}
