using Assignment3.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Persons
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, bool isAdult) : base(name, weight, age, isAdult)
        {
        }

        public void Talk()
        {
            Console.WriteLine($"My name is {this.Name}, I am a wolf man and I can speak Swedish mohahaha");
        }
    }
}
