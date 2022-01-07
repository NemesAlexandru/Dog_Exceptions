using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptions
{
    public class InvalidMinutesException : InvalidSongException
    {
        public InvalidMinutesException(string message = "Song minutes must be between 0 and 14") : base(message)
        {

        }
    }
}
