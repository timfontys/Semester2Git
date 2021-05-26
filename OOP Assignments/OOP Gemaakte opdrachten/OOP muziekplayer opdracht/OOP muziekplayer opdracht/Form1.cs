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
            listBox1.Items.Add(textBoxArtist.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Song song = new Song(textBoxSong.Text, Convert.ToInt32(numericUpDownYear.Value), (Artist)listBox1.SelectedItem, "PathToFile");
            musicPlayer.Add(song);
            listBox2.Items.Add(song);
            comboBoxSong.Items.Add(song);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBoxSong.Text == "") 
            {
                MessageBox.Show("Please Select atleast 1 song");
            }
            else
            {
                Playlist playlist = new Playlist(textBoxPlaylist.Text, (Song)comboBoxSong.SelectedItem);
                musicPlayer.playlist.Add(playlist);
                listBox3.Items.Add(playlist);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            listBox3.Items.Remove(listBox3.SelectedItem);
            musicPlayer.playlist.Remove((Playlist) listBox3.SelectedItem);
            listBox4.Items.Clear();
            textBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = listBox3.SelectedItem.ToString();
            listBox4.Items.Clear();
            listBox4.Items.AddRange(((MusicPlayer)listBox3.SelectedItem).playlist.ToArray());
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            musicPlayer.Play((Song)listBox3.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool isPlaying = true;
            musicPlayer.StopPlaying(isPlaying);
        }
    }
}
