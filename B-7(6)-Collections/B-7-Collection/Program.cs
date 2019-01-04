using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayListExample();
            ArrayListExample2();

            Console.ReadLine();
        }


        static void ArrayListExample2()
        {
            var list = new List<Song>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Next row please");
                var song = new Song()
                {
                    Lyrics = Console.ReadLine()
                };

                list.Add(song);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            list.Sort();
            list.RemoveAt(list.Count - 1);

            foreach (var row in list)
            {
                Console.WriteLine(row.Lyrics);
            }
        }

        public static void ArrayListExample()
        {
            var poem = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                var song = new Song();
                song.Lyrics = Console.ReadLine();
                poem.Add(song);
            }

            //poem.Sort();
            poem.RemoveAt(poem.Count - 1);

            object[] myArray = poem.ToArray();

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
        }


        public class Song : IComparable
        {
            public string Lyrics { get; set; }

            public int CompareTo(object obj)
            {
                var song = obj as Song;

                if (song.Lyrics == this.Lyrics)
                {
                    return 0;
                }

                return song.Lyrics.CompareTo(this.Lyrics);
            }
        }
    }
}
