using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicApp
{
    public class Song
    {
        private string artist;
        private string title;
        private int durationInSeconds;
        private Genre _genre;

        public int id
        {
            get;
            set;
        }

        public Song(int id, string artist, string title, int durationInSeconds, Genre genre)
        {
            this.id = id;
            this.artist = artist;
            this.title = title;
            this.durationInSeconds = durationInSeconds;
            this._genre = genre;
        }

        public int GetId()
        { return this.id; }

        public string GetArtist()
        { return this.artist; }

        public string GetInfo()
        {
            int dur_minutes = this.durationInSeconds / 60;
            int dur_seconds = this.durationInSeconds % 60;

            return $"ID {this.id:00}: {this.artist} - {this.title} ({dur_minutes}:{dur_seconds:00}) - genre: {this._genre}";
        }
    }
}
