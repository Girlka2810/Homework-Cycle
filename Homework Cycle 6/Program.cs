using System;

namespace Homework_Cycle_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 число(N).Выведите N - ое число ряда фибоначчи.
            //В ряду фибоначчи каждое следующее число является суммой двух предыдущих. 
            //Первое и второе считаются равными 1.
            int Nfibo;
            int fibo1 = 1;
            int fibo2 = 1;
            Console.WriteLine("Введите число");
            Nfibo = Convert.ToInt32(Console.ReadLine());
            for (int i=2;i<=Nfibo; i++)
            {
                fibo1 = fibo2 - fibo1;
                fibo2 = fibo1 + fibo2;
            }
            Console.WriteLine($"{Nfibo}-ое число ряда Фибоначчи: " +fibo2);
        }
    }
}
