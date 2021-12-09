using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    internal class Song : SongComponent
    {
        private readonly string songName;
        private readonly string bandName;
        private readonly int yearReleased;

        public Song(string songName, string bandName, int yearReleased)
        {
            this.songName = songName;
            this.bandName = bandName;
            this.yearReleased = yearReleased;
        }

        public override string SongName { get { return songName; } }
        public override string BandName { get { return bandName;} }
        public override int YearRealeased { get { return yearReleased; } }

        public override void DisplaySongInfo()
        {
            Console.WriteLine($"{songName} was created by {bandName} in year {yearReleased}");
        }
    }
}
