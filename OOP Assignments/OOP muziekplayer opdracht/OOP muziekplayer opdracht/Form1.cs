using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_muziekplayer_opdracht
{
    public partial class Form1 : Form
    {
        MusicPlayer musicPlayer = new MusicPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Artist artist = new Artist(textBoxArtist.Text, dateTimePicker.Value); 
            musicPlayer.Add(artist);
            listBox1.Items.Add(artist.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Song song = new Song(textBoxSong.Text, Convert.ToInt32(numericUpDownYear.Value));
            musicPlayer.Add(song);
            listBox2.Items.Add(song);
        }

        private void button3_Click(object sender, EventArgs e)
        {
             Playlist playlist = new Playlist(textBoxPlaylist.Text);
             musicPlayer.Playlist.Add(playlist);
             playlist.Add((Song) listBox2.SelectedItem);
             listBox3.Items.Add(playlist);
        }


        private void button5_Click(object sender, EventArgs e)
        {
            listBox3.Items.Remove(listBox3.SelectedItem);
            musicPlayer.Playlist.Remove((Playlist) listBox3.SelectedItem);
            listBox4.Items.Clear();
            textBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = listBox3.SelectedItem.ToString();
            listBox4.Items.Clear();
            listBox4.Items.AddRange(((Playlist)listBox3.SelectedItem).playlistSongs.ToArray());
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            musicPlayer.Play((Song)listBox3.SelectedItem); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            musicPlayer.Stop((Song)listBox3.SelectedItem);
        }

    }
}
