﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Extra_Inheritance.Problem4.Exceptions
{
    internal class InvalidSongMinutesException : InvalidSongException
    {
        public InvalidSongMinutesException(string message) : base(message)
        {
        }
    }
}
