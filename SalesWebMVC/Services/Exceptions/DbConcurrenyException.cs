﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services.Exceptions
{
    public class DbConcurrenyException : ApplicationException
    {
        public DbConcurrenyException(string message) : base(message)
        {
        }
    }
}
