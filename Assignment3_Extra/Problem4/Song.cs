using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Extra_Inheritance.Problem4
{
    internal class Song
    {
        public Song(string artist, string name, int minutes, int seconds)
        {
            Artist = artist;
            Name = name;
            Minutes = minutes;
            Seconds = seconds;
        }

        public string Artist { get; }

        public string Name { get; }

        public int Minutes { get; }

        public int Seconds { get; }

    }
}
