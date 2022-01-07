using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptions
{
   public class InvalidDogNameException : InvalidDogException
    {
        public InvalidDogNameException(string message = "Name length should be > 2") : base(message)
        {

        }
    }
}
