﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostomerException
{
    public class ClientNotFoundException:Exception
    {
        public ClientNotFoundException() { }
        public ClientNotFoundException(string message) : base(message) { }
    }
}
