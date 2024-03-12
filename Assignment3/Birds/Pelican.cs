using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Birds
{
    internal class Pelican : Bird
    {
        public bool CanTalk { get; set; }

        public Pelican(string name, double weight, int age, bool isFast, bool canTalk) : base(name, weight, age, isFast)
        {
            CanTalk = canTalk;
        }
    }
}
