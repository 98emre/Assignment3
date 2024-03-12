using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Animals
{
    internal class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, double weight, int age, string breed) : base(name, weight, age)
        {
            Breed = breed;
        }

        public override void DoSound()
        {
            Console.WriteLine("Dog: wof wof wof");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Breed: {Breed}";
        }

        public string DogFact()
        {
            return $"My name is {Name} and I am {Breed}";
        }
    }
}
