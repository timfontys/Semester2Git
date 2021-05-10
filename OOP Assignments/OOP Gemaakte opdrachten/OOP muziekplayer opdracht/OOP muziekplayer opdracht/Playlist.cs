using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_muziekplayer_opdracht
{
    class Playlist
    {


        public string PlaylistName { get; private set; }

        public Playlist(string name, Song songs)
        {
            PlaylistName = name;
            Add(songs);
        }

        public void Add(Song song) 
        {
            
        }

        public void Add(List<Song> Songs) 
        {

        }

        public void Remove(Song Song) { }

        public override string ToString()
        {
            return PlaylistName;
        }

    }
}
