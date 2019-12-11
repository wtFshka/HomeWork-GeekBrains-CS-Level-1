using System;
using MyMethods;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для изменнеия значений переменных местами");
            double a = Convert.ToDouble(WriterReader.WriteRead("Введите a").Replace('.', ','));
            double b = Convert.ToDouble(WriterReader.WriteRead("Введите b").Replace('.', ','));
            a += b;
            b = a - b;
            a -= b;
            WriterReader.Pause($"a = {a}, b = {b}");
        }
    }
}
