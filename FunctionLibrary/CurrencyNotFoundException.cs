using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLibrary
{
    public class CurrencyNotFoundException : Exception
    {
        public CurrencyNotFoundException()
        {

        }

        public CurrencyNotFoundException(string message) : base(message)
        {

        }

        public CurrencyNotFoundException(string message, Exception inner):base(message,inner)
        {

        }
    }
}
