using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Persons
{

    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public Person() { }

     
        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Age must be greater than 0");
                }

                age = value;
            }
        }

        public string FName
        {
            get { return fName; }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Trim().Length < 2 || value.Trim().Length > 10)
                {
                    throw new ArgumentException("First name must be 2-10 characters long");
                }

                fName = value.Trim();
            }
        }

        public string LName
        {
            get { return lName; }

            set
            {
                if (string.IsNullOrEmpty(value.Trim()) || value.Trim().Length < 3 || value.Trim().Length > 15)
                {
                    throw new ArgumentException("First name must be 3-15 characters long");
                }

                lName = value.Trim();
            }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public override string ToString()
        {
            return $"Name: {FName} {LName} \nAge: {Age} \nHeight: {Height} \nWeight: {Weight}\n";
        }

    }
}
