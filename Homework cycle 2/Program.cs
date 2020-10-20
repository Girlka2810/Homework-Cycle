using System;

namespace Homework_cycle_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 число (A).
            //Вывести все числа от 1 до 1000, которые делятся на A.
            int a;
            Console.WriteLine("Введите число:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Числа от 1 до 1000, которые делятся на: " + a);
            for (int i = 1; i <= 1000; i += 1)
            {if (i % a == 0)
                    Console.WriteLine("Результат: " + i);
            }
                

        }
    }
}
