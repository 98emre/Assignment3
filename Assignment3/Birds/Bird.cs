using Assignment3.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Birds
{
    internal class Bird : Animal
    {
        public bool IsFast { get; set; }

        public Bird(string name, double weight, int age, bool isFast) : base(name, weight, age)
        {
            IsFast = isFast;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{this.GetType().Name} sound: whistle whistle"); 
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Is Fast: {(IsFast ? "Yes" : "No")}";
        }
    }
}
