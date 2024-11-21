using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingMusicApp
{
    public partial class Form1 : Form
    {
        private StreamingMusicService mservice;
        private string list_of_songs;

        public Form1()
        {
            InitializeComponent();
            this.mservice = new StreamingMusicService("YoMusic");

            UpdateTitleBar();

            lvUsers.Columns.Add("id");
            lvUsers.Columns.Add("user");
            UpdateUsers();

            lvAllAvailableSongs.Columns.Add("id");
            lvAllAvailableSongs.Columns.Add("song");
            UpdateSongs();

            this.cbGenre.DataSource = Enum.GetValues(typeof(Genre));
        }

        private void UpdateTitleBar()
        {
            this.Text = mservice.GetInfo();
        }

        private void UpdateUsers()
        {
            if (mservice.GetUsers().Length > 0)
            {
                User[] u = mservice.GetUsers();
                this.lvUsers.Items.Clear();
                foreach (User a in u)
                {
                    this.lvUsers.Items.Add(new ListViewItem(new string[] { a.GetId().ToString(), a.GetInfo().ToString() }));
                    this.lvUsers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }
        }

        private void UpdateSongs()
        {
            if (mservice.GetSongs().Length > 0)
            {
                Song[] s = mservice.GetSongs();
                this.lvAllAvailableSongs.Items.Clear();
                foreach (Song a in s)
                {
                    this.lvAllAvailableSongs.Items.Add(new ListViewItem(new string[] { a.GetId().ToString(), a.GetInfo().ToString() }));
                    this.lvAllAvailableSongs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewSong_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(tbTitle.Text) || String.IsNullOrEmpty(tbArtist.Text) || String.IsNullOrEmpty(tbDuration.Text)))
            {
                Genre _genre = (Genre)cbGenre.SelectedItem;
                this.mservice.AddSong(tbArtist.Text, tbTitle.Text, int.Parse(tbDuration.Text), _genre);


                Song[] s = mservice.GetSongs();
                this.rtbViewAllSongs.Text = "";
                foreach (Song a in s)
                {
                    this.rtbViewAllSongs.Text += a.GetInfo() + Environment.NewLine;
                }

                UpdateTitleBar();
                UpdateSongs();

                tbTitle.Text = "";
                tbArtist.Text = "";
                tbDuration.Text = "";
            }
        }

        private void btnClearNewSong_Click(object sender, EventArgs e)
        {
            tbTitle.Text = "";
            tbArtist.Text = "";
            tbDuration.Text = "";
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(tbUserName.Text) || String.IsNullOrEmpty(tbEmail.Text) || String.IsNullOrEmpty(tbAddress.Text)))
            {
                this.mservice.AddUser(tbUserName.Text, tbEmail.Text, tbAddress.Text);


                User[] u = mservice.GetUsers();
                this.rtbViewAllUsers.Text = "";
                foreach (User a in u)
                {
                    this.rtbViewAllUsers.Text += a.GetInfo() + Environment.NewLine;
                }

                UpdateTitleBar();
                UpdateUsers();

                tbUserName.Text = "";
                tbEmail.Text = "";
                tbAddress.Text = "";
            }
        }

        private void btnClearNewUser_Click(object sender, EventArgs e)
        {
            tbUserName.Text = "";
            tbEmail.Text = "";
            tbAddress.Text = "";
        }

        private void lvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUsers.SelectedItems.Count == 0)
                return;

            ListViewItem item = lvUsers.SelectedItems[0];

            User u = this.mservice.GetUser(int.Parse(item.Text));
            this.rtbFavoriteSongsUser.Text = u.GetFavoriteSongs();
        }

        private void btnAssignSongToFavourites_Click(object sender, EventArgs e)
        {
            if (lvUsers.SelectedItems.Count == 0)
                return;

            if (lvAllAvailableSongs.SelectedItems.Count == 0)
                return;

            ListViewItem user_item = lvUsers.SelectedItems[0];

            User u = this.mservice.GetUser(int.Parse(user_item.Text));

            foreach (ListViewItem song_item in lvAllAvailableSongs.SelectedItems)
            {
                Song s = this.mservice.GetSong(int.Parse(song_item.Text));
                u.AddSongToFavorites(s);
            }

            this.rtbFavoriteSongsUser.Text = u.GetFavoriteSongs();
        }

    }
}
