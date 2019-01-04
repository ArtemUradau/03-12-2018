using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] six = new[] {1, 2, 3, 4, 5, 6};
            //for (int i = six.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(six[i]);
            //}
            //Console.WriteLine(string.Join(", ", six));
            Random rnd = new Random();
            int [,] six2 = new int[3,4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    six2[i, j] = rnd.Next(100);
                }
            }

            outmass(six2);
            int temp = 0;
            for (int i = 0; i < six2.GetLength(0); i++)
            {
                temp = 0;
                for (int j = 0; j < six2.GetLength(1); j++)
                {
                    if (six2[i,j] >= temp)
                    {
                        temp = six2[i, j];
                    }
                }
                
                Console.WriteLine(temp);
            }

            //PoemGeneration();
            Console.ReadLine();
        }

        public static void PoemGeneration()
        {
            Random rnd = new Random();
            char[][] poem = new char[100][];
            
            for (int i = 0; i <= 99; i++)
            {
                var word = new char[rnd.Next(10)];
                for (int j = 0; j < word.Length; j++)
                {
                    word[j] = (char)rnd.Next(1040 - 1, 1103 - 1);
                }

                poem[i] = word;
                
            }

            foreach (var word in poem)
            {
                Console.WriteLine(word);
            }

            //for (int i = 0; i < poem.Length; i++)
            //{
            //    Console.WriteLine(poem[i]);
            //}
            

        }
        public static void outmass(int [,] six2)
        {
            //for (int i = 0; i < (six2.GetUpperBound(0) + 1); i++)
            //{

            //    for (int j = 0; j < six2.Length / (six2.GetUpperBound(0) + 1); j++)
            //    {
                    
            //        Console.Write($"{six2[i, j], 5}");
            //    }

            //    Console.WriteLine();
            //}
            foreach (var element in six2)
            {
                Console.WriteLine(element);
            }
        }
        public static void Pyatnashki()
        {
           

        }

        public static void PoemExample()
        {
            
        }
    }
}
