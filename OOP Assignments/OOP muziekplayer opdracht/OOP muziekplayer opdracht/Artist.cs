using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_muziekplayer_opdracht
{
    class Artist
    {
        private string name;
        private DateTime birthday;
        public Artist(string Name, DateTime Birthday)
        {
            name = Name;
            birthday = Birthday;
        }

        public override string ToString()
        {
            return name;
        }

    }
}
