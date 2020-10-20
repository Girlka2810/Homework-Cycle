using System;

namespace Homework_Cycle_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 число(A).
            //Вывести наибольший делитель(кроме самого A) числа A.
            int a, nod;
            Console.WriteLine("Введите число:");
            a = Convert.ToInt32(Console.ReadLine());
            nod = 0;
            Console.WriteLine("Наибольший делитель числа " + a);
            for (int i=1; i<a; i+=1)
            { 
                if (a % i == 0)
                    nod = i;
                         }
            Console.WriteLine("Наибольший делитель: "+nod);
        }
    }
}
