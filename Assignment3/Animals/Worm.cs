using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Animals
{
    internal class Worm : Animal
    {
        public bool IsPoisonous { get; set; }

        public Worm(string name, double weight, int age, bool isPoisonous) : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;
        }

        public override void DoSound()
        {
            Console.WriteLine("Worm: Skr skr");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Is Poisonous: {(IsPoisonous ? "Yes" : "No")}";
        }
    }
}
