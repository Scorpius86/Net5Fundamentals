using System;
using System.Collections.Generic;
using System.Text;

namespace Net5.Fundamentals.ControlStructures
{
    public class InvalidOptionException:Exception
    {
        public InvalidOptionException(string message):base(message)
        {
            
        }
    }
}
