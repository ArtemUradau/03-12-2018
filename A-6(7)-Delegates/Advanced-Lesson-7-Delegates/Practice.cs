using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_7_Delegates
{
    public class Practice
    {
        /// <summary>
        /// L7.P1. Переписать консольный калькулятор с использованием делегатов. 
        /// Используйте switch/case, чтоб определить какую математическую функцию.
        /// </summary>
        public static void L7P1_Calculator()
        {
            int value1 = 100;
            int value2 = 200;
            Func<int, int, double> operation = null;

            switch (Console.ReadKey().KeyChar)
            {
                case '+':
                {
                    operation = delegate(int var1, int var2)
                    {
                        return (var1 + var2);
                    };
                    break;
                }
                case '-':
                {
                    operation = (a, b) =>
                    {
                        Console.WriteLine(a);
                        return a - b;
                    };
                    break;
                }
            }

            double result = operation(value1, value2);
            Console.WriteLine($"Result - {result}");
            Console.ReadKey();
        }
        
      
        /// <summary>
        /// L7.P2. Создать расширяющий метод для коллекции строк.
        /// Метод должен принимать делегат форматирующей функции для строки.
        /// Метод должен проходить по всем элементам коллекции и применять данную форматирующую функцию к каждому элементу.
        /// Реализовать следующие форматирующие функции:
        /// Перевод строки в заглавные буквы.
        /// Замена пробелов на подчеркивание.
        /// Продемонстрировать работу расширяющего метода.
        /// </summary>
        public static void L7P2_StringFormater()
        {

        }
    }
}
