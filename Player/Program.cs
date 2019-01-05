using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            //player.Volume = 20;

            var result = GetSongsData();
            var (songs, total, max, min) = result;

            player.Add(songs);

            //int min = result.min;
            //int max = result.max;
            //int total = result.total; 

            Console.WriteLine($"Min = {min}, max = {max}, total = {total}");

//            TraceInfo(player);

            player.Play();
            player.VolumeUp();
            Console.WriteLine(player.Volume);

            player.VolumeChange(-300);
            Console.WriteLine(player.Volume);

            player.VolumeChange(300);
            Console.WriteLine(player.Volume);

            /*player.Volume = -25;
            Console.WriteLine(player.Volume);
            */
            player.Stop();


            var randSong = CreateSong();
            var randSong_2 = CreateSong("Go!");
            var randSong_3 = CreateSong("Signals", 123);
            
            player.Add( randSong , randSong_2, randSong_3 );
            player.Play();

            

            Console.ReadLine();
        }

        public static (Song[], int, int, int) GetSongsData()
        {
            var minDuration = 1000;
            var maxDuration = 0;
            var totalDuration = 0;

            var artist = new Artist();
            artist.Name = "Powerwolf";
            artist.Genre = "Metal";

            var artist2 = new Artist("Lordi");
            Console.WriteLine(artist2.Name);
            Console.WriteLine(artist2.Genre);

            var artist3 = new Artist("Sabaton", "Rock");
            Console.WriteLine(artist3.Name);
            Console.WriteLine(artist3.Genre);

            var album = new Album();
            album.Name = "New Album";
            album.Year = 2018;

            Song[] songs = new Song[10];
            var random = new Random();

            for (int i = 0; i < 10; i++)
            {
                var song = new Song()
                {
                    Duration = random.Next(1000),
                    Name = $"New song {i}",
                    Album = album,
                    Artist = artist
                };
                songs[i] = song;

                totalDuration += songs[i].Duration;
                if (songs[i].Duration < minDuration)
                {
                    minDuration = song.Duration;
                }

                maxDuration = Math.Max(maxDuration, song.Duration);
            }


            //return new Object[]{ songs , totalDuration, maxDuration, minDuration };

            //return new Tuple<Song[], int, int, int>(songs, totalDuration, maxDuration, minDuration);

            return (songs, totalDuration, maxDuration, minDuration);


            //class Tuplesongsarrayintintint {
            //Song[] Item1;
            //int Item2
            //}
        }

        public static void TraceInfo(Player player)
        {
            Console.WriteLine(player.Songs[0].Artist.Name);
            Console.WriteLine(player.Songs[0].Duration);
            Console.WriteLine(player.Songs.Length);
            Console.WriteLine(player.Volume);
        }

        public static Song CreateSong()
        {
            return CreateSong("Her Ghost", 300);
        }
        public static Song CreateSong(string newName)
        {
            return CreateSong(newName, 300);
        }

        public static Song CreateSong(string newName, int newDuration)
        {
            return new Song { Name = newName, Duration = newDuration };
        }
    }
}
