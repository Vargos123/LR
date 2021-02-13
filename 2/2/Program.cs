using System;

namespace _2
{

    public delegate int Operation(int x, int y);

    class Program
    {

        private static int Add(int x, int y) 
        {
            return x + y;
        }
        private static int Sub(int x, int y)
        {
            return x - y;
        }
        private static int Mult(int x, int y)
        {
            return x * y;
        }
        private static int Dell(int x, int y)
        {
            return x / y;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int x, y;
                Console.WriteLine("Введите первое число:");
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Ошибка! Введите целое число:");
                }
                Console.WriteLine("Введите второе число:");
                while (!int.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Ошибка! Введите целое число:");
                }
                Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
                string a = Console.ReadLine();
                switch (a)
                {
                    case "+":
                        Operation add = Add;
                        Console.WriteLine("Ответ: " + add(x, y));
                        break;
                    case "-":
                        Operation sub = Sub;
                        Console.WriteLine("Ответ: " + sub(x, y));
                        break;
                    case "*":
                        Operation mult = Mult;
                        Console.WriteLine("Ответ: " + mult(x, y));
                        break;
                    case "/":
                        if (y == 0)
                            Console.WriteLine("На 0 делить нельзя!");
                        else
                        {
                            Operation dell = Dell;
                            Console.WriteLine("Ответ: " + dell(x, y));
                        }
                        break;
                    default:
                        Console.WriteLine("Выбрана ошибочная операция!");
                        break;
                }

                Console.ReadKey();
            }            
        }
    }
}
