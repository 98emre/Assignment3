using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Extra.Problem3
{
    internal class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName {
            get {  return firstName; }

            set
            {

                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                

                if (value.Trim().Length < 4 || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }

                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }

            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }


                if (value.Trim().Length < 3 || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }

                lastName = value;
            }
        }

    }
}
