using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Extra_Inheritance.Problem4.Exceptions
{
    internal class InvalidSongNameException : InvalidSongException
    {
        public InvalidSongNameException(string message) : base(message)
        {

        }
    }
}
