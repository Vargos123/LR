using System;

namespace _1
{
    class Program
    {
        static void Calculate(int a, int b, int c)
        {
            Console.WriteLine("Среднее арифметическое: " + (a + b + c) / 3);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Введите 1 значение");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число");
            }
            Console.WriteLine("Введите 2 значение");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число");
            }
            Console.WriteLine("Введите 3 значение");
            while (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число");
            }

            Calculate(a, b, c);
        }
    }
}
