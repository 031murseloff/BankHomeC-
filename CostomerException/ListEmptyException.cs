﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostomerException
{
    public class ListEmptyException:Exception
    {

        public ListEmptyException() { }
        public ListEmptyException(string message):base(message) { }

    }
}
