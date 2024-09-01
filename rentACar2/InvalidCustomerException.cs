﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentACar2
{
internal class InvalidCustomerException : Exception
{
        public InvalidCustomerException(customer c) { }

        public InvalidCustomerException(string message)
            : base(message) { }

        public InvalidCustomerException(string message, Exception inner)
            : base(message, inner) { }
    }
}

