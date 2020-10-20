using System;

namespace Homework_Cycle_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 число(A).
            //Найдите количество положительных целых чисел, квадрат которых меньше A.
            int a, count;
            Console.WriteLine("Введите число:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Числа квадрат которых меньше " + a);
            count = 0;
            for (int i=1; i*i<=a; i+=1)
            {
                count+=1;
                
            }
                Console.WriteLine("Количество положительных чисел: "+ count);
        }       



    }
}
