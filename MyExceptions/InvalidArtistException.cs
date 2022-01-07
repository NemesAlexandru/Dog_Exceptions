using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptions
{
    public class InvalidArtistException : InvalidSongException
    {
        public InvalidArtistException(string message = "Artist name length must be between 2 and 20 characters") : base(message)
        {

        }
    }
}
