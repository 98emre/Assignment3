﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Extra.Problem4.Exceptions
{
    internal class InvalidSongSecondsException : InvalidSongException
    {
        public InvalidSongSecondsException(string message) : base(message)
        {

        }
    }
}
