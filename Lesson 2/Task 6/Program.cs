using System;

namespace Task_6
{
    class Program
    {
        //*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
        //«Хорошим» называется число, которое делится на сумму своих цифр. 
        //Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
        static void Main(string[] args)
        {
            int iStart, iEnd, sum, count = 0;
            DateTime startTime = DateTime.Now;
            Console.WriteLine("Программа для подсчёта количества \"хороших\" чисел в заданном диапазоне");
            Console.Write("Введите начало диапазона: ");
            iStart = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конец диапазона: ");
            iEnd = Convert.ToInt32(Console.ReadLine());
            for ( ; iStart <= iEnd; iStart++)
            {
                sum = 0;
                int tempNum = iStart;
                do
                {
                    sum += tempNum % 10;
                    tempNum /= 10;
                } while (tempNum != 0);
                if (iStart%sum==0)
                {
                    count++;
                }
            }
            Console.WriteLine($"В заданном диапазоне обнаружено {count} \"хороших\" чисел.\nПрограмма завершена за {DateTime.Now-startTime}");
            Console.ReadKey();
        }
    }
}
