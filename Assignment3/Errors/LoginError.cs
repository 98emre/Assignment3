﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Errors
{
    internal class LoginError : UserError
    {
        public override string UEMessage()
        {
            return "Error occured while you tried to login!";
        }
    }
}
