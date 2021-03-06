﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution06
{
    public class MyCustomException : Exception
    {
        public MyCustomException() : base()
        {

        }

        public MyCustomException(string message): base(message)
        {
        }
        
        public MyCustomException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public string MyCustomMessage { get;}

    }
}
