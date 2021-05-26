using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_muziekplayer_opdracht
{
    class Playlist
    {
        public string Name { get; private set; }
        //  public List<Song> songs = new List<Song>();

        public List<Song> playlistSongs = new List<Song>();

        public Playlist(string name)
        {
            Name = name;
        }

       public void Add(Song song) 
        {
            playlistSongs.Add(song);
        }

        public void Add(List<Song> songs) 
        {
            playlistSongs.AddRange(songs);
        }

        public void Remove(Song song) 
        {
            playlistSongs.Remove(song);
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
