using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Banking
{
    class BankExeception : ApplicationException
    {
        public BankExeception(string message) : base(message)
        {
        }
    }
}
