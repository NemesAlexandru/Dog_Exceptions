using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptions
{
   public class InvalidSecondsException : InvalidSongException
    {
        public InvalidSecondsException(string message = "Song seconds must be between 1 and 59 seconds") : base(message)
        {

        }
    }
}
