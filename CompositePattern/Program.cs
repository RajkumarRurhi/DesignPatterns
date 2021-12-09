using System;

namespace CompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SongComponent allSongs = new SongGroup("All Songs", "All songs description");

            SongComponent songGroup1 = new SongGroup("Song Group 1", "Song Group 1");

            Song song11 = new Song("Song11", "Band11", 2011);
            Song song12 = new Song("Song12", "Band12", 2012);

            SongComponent songGroup2 = new SongGroup("Song Group 2", "Song Group 2");
            Song song21 = new Song("Song21", "Band21", 2001);
            Song song22 = new Song("Song22", "Band22", 2002);
            songGroup2.Add(song21);
            songGroup2.Add(song22);

            songGroup1.Add(song11);
            songGroup1.Add(song12);
            songGroup1.Add(songGroup2);

            SongComponent songGroup3 = new SongGroup("Song Group 3", "Song Group 3");
            Song song31 = new Song("Song31", "Band31", 2005);
            Song song32 = new Song("Song32", "Band32", 2007);
            songGroup3.Add(song31);
            songGroup3.Add(song32);

            allSongs.Add(songGroup1);
            allSongs.Add(songGroup3);

            allSongs.DisplaySongInfo();

            Console.ReadLine();
        }
    }
}
