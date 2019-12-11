using System;
using MyMethods;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;
            Console.WriteLine("Программа для расчета расстояния между точками Х1:Х2 Y1:Y2");
            x1 = Convert.ToDouble(WriterReader.WriteRead("Введите X1"));
            x2 = Convert.ToDouble(WriterReader.WriteRead("Введите X2"));
            y1 = Convert.ToDouble(WriterReader.WriteRead("Введите Y1"));
            y2 = Convert.ToDouble(WriterReader.WriteRead("Введите Y2"));
            WriterReader.Pause($"Расстояние мужду точками равно: {Distance(x1, x2, y1, y2)}");
        }
        static double Distance(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
