﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3SemesterREST.Models
{
    public class CarException : Exception
    {
        CarException(string message) : base(message)
        {

        }
    }
}
