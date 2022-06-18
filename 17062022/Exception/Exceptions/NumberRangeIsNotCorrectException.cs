using System;
using System.Collections.Generic;
using System.Text;

namespace Exception.Exceptions
{
    internal class NumberRangeIsNotCorrectException:System.Exception
    {
        public NumberRangeIsNotCorrectException(string msg):base(msg)
        {

        }
    }
}
