using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_2_Inheritance
{
    public static partial class Practice
    {
        /// <summary>
        /// A.L2.P1/1. Создать консольное приложение, которое может выводить 
        /// на печатать введенный текст  одним из трех способов: 
        /// консоль, файл, картинка. 
        /// </summary>
        public static void A_L2_P1_1()
        {
            Console.WriteLine("Choose print type:");
            Console.WriteLine("1 - Console");
            Console.WriteLine("2 - File");
            Console.WriteLine("3 - Image");

            string type = Console.ReadLine();

            Printer printer = null;

            switch (type)
            {
                case "1":
                    printer = new ConsolePrinter("***",ConsoleColor.Blue);
                    break;
                case "2":
                    printer = new FilePrinter("***","test");
                    break;
                case "3":
                    Console.WriteLine("You have chosen printing into image");
                    break;
            }

            Console.WriteLine("Write text");

            for (int i = 0; i < 5; i++)
            {
                printer.PrintingText = Console.ReadLine();
                printer?.Print();
            }
        }  
        
        public  abstract class Printer
        {
            public abstract void Print();

            public Printer(string str)
            {
                PrintingText = str;
            }

            public string PrintingText { get; set; }
        }
        public class ConsolePrinter : Printer
        {
            public override void Print()
            {
                Console.ForegroundColor = _color;
                Console.WriteLine(PrintingText);
                Console.ResetColor();
            }

            public ConsolePrinter(string str, ConsoleColor color):base(str)
            {
                _color = color;
            }

            private ConsoleColor _color;
        }
        public class FilePrinter : Printer
        {
            public override void Print()
            {
                System.IO.File.AppendAllText($@"D:\{_fileName}.txt",PrintingText);
            }

            public FilePrinter(string str, string fileName) : base(str)
            {
                _fileName = fileName;
            }

            private string _fileName;
        }

    }
}
