using System;

namespace Task_2
{
    class Program
    {
        //Написать метод подсчета количества цифр числа.
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для подсчета количества цифр в числе.");
            Console.Write("Введите число: ");
            Console.WriteLine($"В Вашем числе, {CountNumbers(Console.ReadLine())} цифр");
            Console.ReadKey();
        }
        static int CountNumbers(string str)
        {
            int count = 0;
            foreach (var s in str)
            {
                if (char.IsDigit(s))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
