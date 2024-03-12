using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Persons
{
    internal class PersonHandler
    {
        public PersonHandler() { }


        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }

        public void SetFirstName(Person person, string firstName)
        {
            person.FName = firstName;
        }

        public void SetLastName(Person person, string lastName)
        {
            person.LName = lastName;
        }

        public void SetHeight(Person person, double height)
        {
            if(height <= 0)
            {
                throw new ArgumentException("Height can not be less than 1");
            }

            person.Height = height;
        }

        public void SetWeight(Person person, double weight) { 
            if(weight <= 0)
            {
                throw new ArgumentException("Weight can not be less than 1");
            }

            person.Weight = weight;
        }


        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person person = new Person();

            person.Age = age;
            person.FName = fName;
            person.LName = lName;
            person.Height = height;
            person.Weight = weight;

            return person;
        }

        public string GetPersonInfo(Person person)
        {
            return person.ToString();
        }
    }


}
