using System;

namespace Homework_Cycle_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 числа.
            //Найти их наибольший общий делитель используя алгоритм Евклида.
            Console.WriteLine("Алгоритм Евклида");
            int a, b,a1,b1;
            Console.WriteLine("Введите первое число");
            Console.Write("A= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            Console.Write("B= ");
            b = Convert.ToInt32(Console.ReadLine());
            a1 = a;
            b1 = b;
            while (a!=0 && b!=0)
            {
                if (a > b)
                    a -= b;
                else
                    b-= a;
            }
          Console.WriteLine($"Наибольший делитель чисел {a1} и {b1} : {Math.Max(a,b)} ");
        }
    }
}
