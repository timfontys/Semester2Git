using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_muziekplayer_opdracht
{
    class MusicPlayer
    {
        public List<Artist> Artist = new List<Artist>();
        public List<Playlist> Playlist = new List<Playlist>();
        public List<Song> Song = new List<Song>();
        public void Add(Artist artist) // NULL check
        {
            Artist.Add(artist);
        }
        public void Add(Playlist playlist) 
        {
            Playlist.Add(playlist);
        }
        public void Add(Song song) 
        {
            Song.Add(song);
        }

        public void Play(Song song) 
        { 

        }

        public void Stop(Song song) 
        { 

        }

    }
}
