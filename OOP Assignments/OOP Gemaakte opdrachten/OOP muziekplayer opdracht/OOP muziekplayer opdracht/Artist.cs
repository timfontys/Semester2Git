using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_muziekplayer_opdracht
{
    class Artist
    {
        public string Name { get; private set; }
        public DateTime Birthday { get; private set; }
        public Artist(string nameArtist, DateTime birthdayArtist)
        {
            Name = nameArtist;
            Birthday = birthdayArtist;
        }

        public void Add(Song song) 
        {

        }

        public override string ToString()
        {
            return Name;
        }

    }
}
