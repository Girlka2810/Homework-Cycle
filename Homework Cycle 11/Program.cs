using System;

namespace Homework_Cycle_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит целое положительное  число(N).
            //Выведите количество чисел в диапазоне от 1 до N, 
            //сумма четных цифр которых больше суммы нечетных. 
            Console.WriteLine("Сумма четных цифр больше суммы нечетных");
            Console.WriteLine("Введите целое положительное число");
            int currentValue = Convert.ToInt32(Console.ReadLine());
            int oddNumberCount = 0;
            int evenNumberCount = 0;
            int x = 0;
            for (int i = 1; i < currentValue; i++)
            {
                int evenNumberSum = 0;
                int oddNumberSum = 0;
                int buf = i;
                while (buf%10!=0)
                {
                    if (buf % 2 == 0)
                    {
                        evenNumberSum += buf % 10;
                    }
                    else
                        oddNumberSum += buf % 10;
                    buf /= 10;
                }

                if (evenNumberSum > oddNumberSum)
                    x++;
            }
            Console.WriteLine($"Количество количество чисел в диапазоне от 1 до {currentValue} сумма четных цифр которых больше суммы нечетных равно {x}");





        }   
    }
}
