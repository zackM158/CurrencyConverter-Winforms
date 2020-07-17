﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLibrary
{
    public static class ExtraFunctions
    {
        public static double SetSigFigs(double d, int digits)
        {
            if (d == 0)
                return 0;

            decimal scale = (decimal)Math.Pow(10, Math.Floor(Math.Log10(Math.Abs(d))) + 1);

            return (double)(scale * Math.Round((decimal)d / scale, digits));
        }
    }
}
