using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Birds
{
    internal class Swan : Bird
    {
        private bool IsAdult {  get; set; }

        public Swan(string name, double weight, int age, bool isFast, bool isAdult) : base(name, weight, age, isFast)
        {
            IsAdult = isAdult;
        }
    }
}
