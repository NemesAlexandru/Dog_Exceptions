using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptions
{
   public class LowerThanLimitDogAgeException : ArgumentException
    {
        public LowerThanLimitDogAgeException(string message = "Dog age must be > 2") : base(message)
        {

        }
    }
}
