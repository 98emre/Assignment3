using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Errors
{
    internal class EmailError : UserError
    {
        public override string UEMessage()
        {
            return "Wrong email input!";
        }
    }
}
