using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Animals
{
    internal class Wolf : Animal
    {
        public bool IsAdult { get; set; }

        public Wolf(string name, double weight, int age, bool isAdult) : base(name, weight, age)
        {
            IsAdult = isAdult;
        }

        public override void DoSound()
        {
            Console.WriteLine("Wolf: grrr grrr");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Is Adult: {(IsAdult ? "Yes" : "No")}";
        }
    }
}
