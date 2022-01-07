using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptions
{
   public class GreaterThanLimitDogAgeException : InvalidDogException
    {

        public GreaterThanLimitDogAgeException(string message = "Dog age must be < 100") : base(message)
        {

        }
    }
}
