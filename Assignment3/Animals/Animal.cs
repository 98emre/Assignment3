using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Animals
{
    internal abstract class Animal
    {

        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public abstract void DoSound();

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public virtual string Stats()
        {
            return $"GetType: {this.GetType().Name}, Name: {Name}, Weight: {Weight}, Age: {Age}";
        }


    }
}
