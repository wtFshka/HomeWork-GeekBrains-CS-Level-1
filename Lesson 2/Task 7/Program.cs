using System;

namespace Task_7
{
    class Program
    {
        //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Программа вывода чисел от a до b");
            Console.Write("Введите a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сумма выведенных чисел: {Counting(a, b)}");
            Console.ReadKey();
        }
        static int Counting(int a, int b)
        {
            if (a<b)
            {
                Console.WriteLine(a);
                a++;              
                return Counting(a, b) + a - 1;      
            } 
            return 0;
        }
    }
}
