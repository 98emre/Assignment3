using Assignment3_Extra.Problem4.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Extra.Problem4
{
    internal class PlayList
    {
        List<Song> songs;

        public PlayList() { 
            songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            if(song.Artist.Length < 3 || song.Artist.Length > 20)
            {
                throw new InvalidArtistNameException("Artist name should be between 3 and 20 symbols");
            }

            if (song.Name.Length < 3 || song.Name.Length > 30) 
            {
                throw new InvalidSongNameException("Song name should be between 3 and 30 symbols.");
            }

            if (song.Minutes < 0 || song.Minutes > 14)
            {
                throw new InvalidSongMinutesException("Song minutes should be between 0 and 14");
            }

            if(song.Seconds < 0 || song.Seconds > 59)
            {
                throw new InvalidSongSecondsException("Song seconds should be between 0 and 59.");
            }

            if (song.Minutes == 14 && song.Seconds > 59)
            {
                throw new InvalidSongLengthException("Invalid song length.");
            }

            songs.Add(song);
            Console.WriteLine("Song added");
        }

        public TimeSpan GetTotalPlayListLength()
        {
            int totalSeconds = 0;

            foreach(Song song in songs)
            {
                totalSeconds += song.Minutes * 60 + song.Seconds;
            }

            return TimeSpan.FromSeconds(totalSeconds);
        }

        public void PrintPlayListInfo()
        {
            Console.WriteLine($"Songs added: {songs.Count}");
            Console.WriteLine($"Playlist Length: {GetTotalPlayListLength().Hours}h {GetTotalPlayListLength().Minutes}m {GetTotalPlayListLength().Seconds}s");
        }
    }
}
