using MyMethods;
using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для вычисления ИМТ (индекса массы тела) человека.");
            double weight = Convert.ToDouble(WriterReader.WriteRead("Введите массу тела в килограммах").Replace('.', ','));
            double height = Convert.ToDouble(WriterReader.WriteRead("Введите рост в метрах").Replace('.',','));
            WriterReader.Pause($"Индекса вашей массы тела равен: {weight / (height * height):F}");
        }
    }
}
