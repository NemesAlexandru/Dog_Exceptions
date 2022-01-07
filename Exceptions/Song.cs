using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExceptions;

namespace Exceptions
{
   public class Song
    {

        private string name;  // min 3 chars, max 30
        private string artist; // min 2 chars, max 20
        private int minutes; // min 0, max 14
        private int seconds; // min 0, max 59

        public Song(string name, string artist, int minutes, int seconds)
        {
            this.Name = name;
            this.Artist = artist;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public string Name { 
            get 
            {
              return this.name;
            }
            set
            {
                if (value.Length > 3 && value.Length <= 30)
                {
                    this.name = value;
                }
                else
                {
                    // Invalid SongName

                    throw new InvalidSongNameException();
                }
            }
        }

        public string Artist {
            get
            {
                return this.artist;
            }

            set {
                if (value.Length > 2 && value.Length <= 20)
                {
                    this.artist = value;
                }
                else
                {
                    throw new InvalidArtistException();
                }
            
            } }

        public int Minutes { 
            
            get
            {
                return this.minutes;

            }


            set 
            {
                if (value > 0 && value <= 14)
                {
                    this.minutes = value;
                }
                else
                {
                    throw new InvalidMinutesException();
                }
            
            } 
        
        }

        public int Seconds {
            get
            {
                return this.seconds;
            }

            set
            {
                if (value > 0 && value <= 59)
                {
                    this.seconds = value;
                }
                else
                {
                    throw new InvalidSecondsException();
                }
            }
        }
    }
}
