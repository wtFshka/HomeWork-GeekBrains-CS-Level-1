using System;

namespace Task_1
{
    class Program
    {
        //Изменить программу вывода таблицы функции так, чтобы можно было передавать функции
        //типа double (double, double). Продемонстрировать работу на функции с функцией a * x^2 и
        //функцией a* sin(x).
        public delegate double Fun(double a, double x);
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine($"| {x,8:0.000} | {F(x, b),8:0.000} |");
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        public static double MyFunc(double a, double x)
        {
            return a * Math.Pow(x,2);
        }
        public static double MyFunc2(double a, double x)
        {
            return a * Math.Sin(x);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Таблица функции MyFunc (a * x^2):");
            Table(MyFunc, -2, 2);
            Console.WriteLine("Таблица функции MyFunc2 (a * Math.Sin(x)):");
            Table(MyFunc2, -2, 2);
            Console.WriteLine("Таблица функции Math.Pow:");
            Table(Math.Pow, -2, 2); 
            Console.WriteLine("Таблица функции a + x * 2:");
            Table(delegate (double a, double x) { return a + x * x; }, -2, 2);
            Console.ReadKey();
        }
    }
}
