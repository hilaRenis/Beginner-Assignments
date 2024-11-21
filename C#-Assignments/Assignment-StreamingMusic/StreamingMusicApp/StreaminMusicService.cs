using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicApp
{
    public class StreamingMusicService
    {
        private int songIdSeeder;
        private int userIdSeeder;
        private string name;
        private List<Song> songs;
        private List<User> users;

        public StreamingMusicService(string name)
        {
            this.songIdSeeder = 1;
            this.userIdSeeder = 1;
            this.name = name;
            this.songs = new List<Song>();
            this.users = new List<User>();
        }

        public void AddSong(string artist, string title, int durationInSeconds, Genre _genre)
        {
            this.songs.Add(new Song(this.songIdSeeder, artist, title, durationInSeconds, _genre));
            this.songIdSeeder++;
        }

        public Song GetSong(int id)
        {
            foreach (Song s in this.songs)
            {
                if (id == s.GetId())
                { return s; }
            }
            return null;
        }

        public Song[] GetSongs()
        {
            return this.songs.ToArray();
        }

        public Song[] GetSongs(string artist)
        {
            List<Song> foundSongs = new List<Song>();
            foreach (Song s in this.songs)
            {
                if (artist == s.GetArtist())
                { foundSongs.Add(s); }
            }
            return foundSongs.ToArray();
        }

        public string GetInfo()
        {
            return $"Streaming Music service: {this.name} ({this.songs.Count} songs & {this.users.Count} users)";
        }


        public void AddUser(string name, string email, string address)
        {
            this.users.Add(new User(this.userIdSeeder, name, email, address));
            this.userIdSeeder++;
        }

        public User GetUser(int id)
        {
            foreach (User u in this.users)
            {
                if (id == u.GetId())
                { return u; }
            }
            return null;
        }

        public User[] GetUsers()
        {
            return this.users.ToArray();
        }
    }
}
