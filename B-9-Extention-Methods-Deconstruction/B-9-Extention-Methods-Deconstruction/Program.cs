using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Lesson_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Practice.Practice.L9_P_EX_1_from_2();
            //Practice.Practice.L9_P_EX_2_from_2();
            Lesson.Lesson.DeconstructExample();
            


            var array = new List<int> { 2, 6, 8, 9 };
            var maxNumber = array.Max();

            var songs = new List<Song> {
                new Song { Name = "a", Duration= 125 },
                new Song { Name = "ab", Duration= 56 },
                new Song { Name = "sdfas", Duration= 45 },
                new Song { Name = "tttatt", Duration= 67 },
            };


            var grouped = songs.GroupBy(x => x.Name);

            var startWithAResult = songs
                .Where(x => x.Name.StartsWith("a"))
                .OrderBy(x => x.Duration);


            var result333 = from song in songs where song.Name.StartsWith("a")
                            orderby song.Duration select song;

            var s = songs.FirstOrDefault(x => x.Name == "tttatt");

            var r1 = songs.Where(x => x.Name.StartsWith("a"));
            var r2 = r1.OrderBy(x => x.Duration);

            songs.ForEach(x => x.Name += "25");

            Console.ReadLine();

        }


        public class Song
        {
            public string Name;
            public int Duration;
        }


    }
}
