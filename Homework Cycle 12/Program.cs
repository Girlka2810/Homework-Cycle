using System;

namespace Homework_Cycle_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 числа.
            //Сообщите, есть ли в написании двух чисел одинаковые цифры. 
            //Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
            Console.WriteLine("Есть ли одинаковые числа?");
            Console.Write("Введите 1-ое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2-ое число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            while (a % 10 != 0)
            {
                while (b % 10 != 0)
                {
                    if (a % 10 == b % 10)
                    {
                        Console.WriteLine($"В числах {a} и {b} есть одинаковые цифры");
                    }
                    else
                    {
                        Console.WriteLine($"В числах {a} и {b} нет одинаковых цифр");
                    }
                    b /= 10;
                }
                a /= 10;
            }
        }
    }
}

