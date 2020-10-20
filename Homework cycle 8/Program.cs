using System;

namespace Homework_cycle_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит целое положительное число, которое является кубом числа N.
            //Найдите число N методом половинного деления. 
            Console.WriteLine("Половинное деление");
            double n;
            Console.WriteLine("Введите целое положительное число N");
            Console.Write("N= ");
            n = Convert.ToInt32(Console.ReadLine());
            double rightBoarder = n;
            double leftBoarder = 0;
            double midPoint = 0;
            double accuracy = 1;
            while (rightBoarder - leftBoarder >= accuracy)
            {
                midPoint = (leftBoarder + rightBoarder) / 2.0;
                if (midPoint*midPoint*midPoint==n)
                {
                    break;
                }
                if ( midPoint * midPoint * midPoint > n)
                {
                    rightBoarder = midPoint;
                }
                else
                {
                    leftBoarder = midPoint;
                }
               // if (Math.Abs(leftBoarder - rightBoarder) <= accuracy)
               
            }
            Console.WriteLine(midPoint);
        }
    }
}
