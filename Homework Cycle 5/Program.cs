using System;

namespace Homework_Cycle_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 числа(A и B).
            //Вывести сумму всех чисел из диапазона от A до B, которые делятся на 7. 
            //(Учтите, что при вводе B может оказаться меньше A).
            int a, b;
            int sum = 0;
            Console.WriteLine("Введите первое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = Convert.ToInt32(Console.ReadLine());
            {
                for (int i=0; i <= b; i++)
                {
                    if (i % 7 == 0)
                        sum += i;
                }
            }
            {
               for (int i = 0; i <= a; i++)
                {
                   if (i % 7 == 0)
                        sum += i;
                }

            }
                if (a>b)
                Console.WriteLine($"Сумма числ в диапозоне от {b} до {a} :" + sum);
                else
                Console.WriteLine($"Сумма числ в диапозоне от {a} до {b} :" + sum);
            
        }
    }
}
