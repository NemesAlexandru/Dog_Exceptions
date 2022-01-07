using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptions
{
  public class InvalidSongException : ApplicationException
    {

        public InvalidSongException(string message = "Invalid song") : base(message)
        {

        }

    }
}
