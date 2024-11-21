using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicApp
{
    public class User
    {
        private string name;
        private string email;
        private string address;
        private static int MAX_SONGS_IN_FAVOURITES = 50;
        private List<Song> user_favourite_songs;

        public int id 
        { 
            get;
            set; 
        }

        public User(int id, string name, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.user_favourite_songs = new List<Song>();
        }

        public User(int id, string name, string email, string address)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.address = address;
            this.user_favourite_songs = new List<Song>();
        }

        public int GetId()
        { return this.id; }

        public void AddSongToFavorites(Song song)
        {
            if (!this.user_favourite_songs.Any(item => item.id == song.id))
            {
                if (this.user_favourite_songs.Count <= MAX_SONGS_IN_FAVOURITES)
                {
                    this.user_favourite_songs.Add(song);
                }
            }
        }

        public void RemoveSongFromFavorites(Song song)
        {
            if (this.user_favourite_songs.Any(item => item.id == song.id))
            {
                this.user_favourite_songs.Remove(this.user_favourite_songs.Single(item => item.id == song.id));
            }
        }

        public string GetFavoriteSongs()
        {
            if (this.user_favourite_songs.Count == 0)
            {
                return $"{this.name} has no favorite songs!";
            }
            else
            {
                string favourite_songs_of_user = $"Favourite songs of {this.name}:" + Environment.NewLine;

                foreach (Song song in this.user_favourite_songs)
                {
                    favourite_songs_of_user = favourite_songs_of_user + "- " + song.GetInfo() + Environment.NewLine;
                }
                return favourite_songs_of_user;
            }
        }

        public string GetInfo()
        {
            return $"ID {this.id:00}: {this.name} - email: {this.email} - address: {this.address}";
        }
    }
}
