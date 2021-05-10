using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_muziekplayer_opdracht
{
    class Song
    {
        // atributen moeten van klassen diagram exact worden overgenomen

        public string Name { get; private set; }
        public int Year { get; private set; }
        public string PathToFile { get; private set; }
        public string Lyrics { get; private set; }


        public Song(string name, int year, Artist artist, string pathToFile) // parameters moeten met kleine letter
        {
            Name = name;
            Year = year;
            PathToFile = pathToFile;
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
