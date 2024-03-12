using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Extra.Inheritance.Problem1
{
    internal class Person
    {
        private int age;
        private string name;

        public Person()
        {

        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public virtual string Name
        {
            get { return name; }

            set
            {
                if(value.Trim().Length < 3)
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!\n");
                }

                name = value;
            }

        }

        public virtual int Age 
        {
            get { return age;  }

            set { 
                  
                if(value < 0)
                {
                    throw new ArgumentException("Age must be positive");
                }

               age = value;
            }
       }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("Name: {0}, Age: {1}", Name, Age));

            return sb.ToString();
        }


    }
}
