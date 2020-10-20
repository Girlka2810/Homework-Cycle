using System;

namespace Homework_Cycle 
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int c = 1;
            Console.WriteLine("Введите первое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < b; i ++) 
            {
                c=c*a;
            }
            Console.Write("Результат: ");   
            Console.WriteLine(c);

        }
    }
}
