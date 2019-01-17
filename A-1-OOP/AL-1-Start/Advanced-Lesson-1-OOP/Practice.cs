using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    public class Practice
    {
        /// <summary>
        /// A.L1.P1. Вывести матрицу (двумерный массив) отображающую площадь круга, 
        /// квадрата, равнобедренного треугольника со сторонами (радиусами) от 1 до 10.
        /// </summary>
        public static void A_L1_P1_OOP()
        {
            var circle1 = new Circle(3);
            var circle2 = new Circle(5);

            var square1 = new Square(2);
            var square2 = new Square(4);

            var arr = new Figure [] { circle1, circle2, square1, square2 };
            for (int i = 0; i < 4; i++)
            {
                //arr[i].CalcArea();
                Console.WriteLine(arr[i].CalcArea());
            }

            var @int = new Circle(2);
        }

        public static void @system()
        {

        }

        class Circle:Figure
        {
            private int rad;
            public Circle(int rad)
            {
                this.rad = rad;
            }
            public override double CalcArea()
            {
                return Math.PI * rad * rad;
            }
        }

        class Square:Figure
        {
            private int a;
            public Square(int a)
            {
                this.a = a;
            }
            public override double CalcArea()
            {
                return a * a;
            }
        }

        class Figure
        {
            public virtual double CalcArea()
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// A.L1.P6. Перегрузить следующие операторы для Transport <>,==/!= на базе физических размеров. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P6_OperatorsOverloading()
        {
        }

        /// <summary>
        /// A.L1.P7.Перегрузить операторы<>,==/!=  для продаваемых вещей в интернет магазине на базе их цены. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P7_OperatorsOverloading()
        {            
        }        
    }
}
