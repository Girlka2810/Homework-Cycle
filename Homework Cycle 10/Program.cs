using System;

namespace Homework_Cycle_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 число.
            //Найти число, которое является зеркальным отображением последовательности цифр заданного 
            //числа, например, задано число 123, вывести 321.
            Console.WriteLine("Число задом на перед");
            int a,a1, b;
            Console.WriteLine("Введите  число ");
            Console.Write("A= ");
            a = Convert.ToInt32(Console.ReadLine());
            a1 = a;
            b = 0;
            while (a!=0)
            {
                b = b * 10 + a % 10;   
                a = a / 10;
            }
                Console.WriteLine($"Число {a1} в обратном порядке: {b}");
        }
    }
}
