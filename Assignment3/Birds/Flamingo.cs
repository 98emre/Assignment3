using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Birds
{
    internal class Flamingo : Bird
    {
        public bool HaveOneLeg { get; set; }

        public Flamingo(string name, double weight, int age, bool isFast, bool haveOneLeg) : base(name, weight, age, isFast)
        {
            HaveOneLeg = haveOneLeg;
        }
    }
}
