using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Animals
{
    internal class Horse : Animal
    {
        public string Color { get; set; }

        public Horse(string name, double weight, int age, string color) : base(name, weight, age)
        {
            Color = color;
        }

        public override void DoSound()
        {
            Console.WriteLine("Horse: hihihi");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Color: {Color}";
        }
    }
}
