using System;

namespace Task_1
{
    class Program
    {
        //Написать метод, возвращающий минимальное из трёх чисел.
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для вычисления меньшего из 3х чисел");
            Console.Write("Введите число х: ");
            double x = Convert.ToDouble(Console.ReadLine().Replace('.',','));            
            Console.Write("Введите число y: ");
            double y = Convert.ToDouble(Console.ReadLine().Replace('.',','));
            Console.Write("Введите число z: ");
            double z = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
            Console.WriteLine($"Меньшее число: {Min(x, y, z)}");
            Console.ReadKey();
        }
        static double Min(double x, double y, double z)
        {
            if (x < y && x < z)
            {
                return x;
            }
            else if (y < x && y < z)
            {
                return y;
            }
            else
            {
                return z;
            }

        }
    }
}
