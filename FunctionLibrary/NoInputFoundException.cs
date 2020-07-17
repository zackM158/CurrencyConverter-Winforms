﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLibrary
{
    public class NoInputFoundException : Exception
    {
        public NoInputFoundException()
        {

        }

        public NoInputFoundException(string message) : base(message)
        {

        }

        public NoInputFoundException(string message, Exception inner):base(message,inner)
        {

        }
    }
}
