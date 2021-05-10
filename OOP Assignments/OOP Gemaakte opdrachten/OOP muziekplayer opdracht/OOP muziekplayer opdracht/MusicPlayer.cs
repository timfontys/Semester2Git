using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_muziekplayer_opdracht
{
    class MusicPlayer
    {

        public List<Artist> artist = new List<Artist>();
        public List<Playlist> playlist = new List<Playlist>();
        public List<Song> song = new List<Song>();

        public void Add(Artist Artist) 
        {
            if (Artist != null) 
            {
                artist.Add(Artist);
            }
        }
        public void Add(Playlist Playlist) 
        {
            if (Playlist != null)
            {
                playlist.Add(Playlist);
            }
        }
        public void Add(Song Song) 
        {
            if (Song != null)
            {
                song.Add(Song);
            }
        }

        public void Remove() { }

        public void Play(Song Song) 
        { 

        }

        public void Play(Playlist Playlist) 
        {
        }

        public void IsPlaying(bool IsPlaying) 
        {
        }

        public void StopPlaying(bool IsPlaying) 
        { 

        }

    }
}
