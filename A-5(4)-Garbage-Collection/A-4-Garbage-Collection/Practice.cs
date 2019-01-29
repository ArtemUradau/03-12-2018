using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advenced.Lesson_4
{
    public partial class Practice
    {
        /// <summary>
        /// AL4-P1/5.InstanceCounter. 
        /// AL4-P2/5.InstanceCounterWithHeapSize.
        /// AL4-P3/5.InstanceCounterWithGCCollect.
        /// </summary>
        public class MyClass : IDisposable
        {
            public static int Number { get; set; }

            public MyClass() => Number++;
            ~MyClass()
            {
                //Number--;
                Dispose();
            }
            public void Dispose()
            {
                Number--;
                System.GC.SuppressFinalize(this);
            }
        }

        public static void AL4_P1_P2_P3_5_InstanceCounter()
        {
            for (int i = 0; i < 500000; i++)
            {
                using (var bla = new MyClass())
                {
                    if (i % 50000 == 0)
                    {
                        Console.WriteLine("{0,30} - {1}", MyClass.Number, System.GC.GetTotalMemory(false));
                        System.GC.Collect();
                        Console.WriteLine("{0,30} - {1}", MyClass.Number, System.GC.GetTotalMemory(false));
                    }
                    //bla.Dispose(); - не надо теперь)))
                }
            }
        }

        /// <summary>
        /// AL4-P4/5. IDisposable. 
        /// AL4-P4/5. IDisposableWithSuppress. 
        /// </summary>
        public static void AL4_P4_P5_5_InstanceCounter()
        {
        }
    }
}
