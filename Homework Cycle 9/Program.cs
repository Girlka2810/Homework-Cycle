using System;

namespace Homework_Cycle_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 число.Найти количество нечетных цифр этого числа.
            Console.WriteLine("Количество нечетных чисел");
            int a,a1,chet,nechet;
            Console.WriteLine("Введите  число ");
            Console.Write("A= ");
            a = Convert.ToInt32(Console.ReadLine());
            chet = 0;
            nechet = 0;
            a1 = a;
            while (a>0)
            {
                if (a % 2 == 0)
                    chet += 1;
                else
                    nechet += 1;
                a = a / 10;
            }
            Console.WriteLine($"Количество нечетных чисел в числе {a1} : {nechet}");

        }
    }
}
