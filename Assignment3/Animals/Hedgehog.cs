using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Animals
{
    internal class Hedgehog : Animal
    {
        public int NumberOfSpikes { get; set; }
        
        public Hedgehog(string name, double weight, int age, int numberOfSpikes) : base(name, weight, age)
        {
            this.NumberOfSpikes = numberOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("Hedgehog: sniff sniff");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Number Of Spikes: {NumberOfSpikes}";
        }
    }
}
