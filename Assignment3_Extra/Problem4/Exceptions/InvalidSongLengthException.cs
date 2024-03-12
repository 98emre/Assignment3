using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Extra_Inheritance.Problem4.Exceptions
{
    internal class InvalidSongLengthException : InvalidSongException
    {
        public InvalidSongLengthException(string message) : base(message)
        {
        }
    }
}
