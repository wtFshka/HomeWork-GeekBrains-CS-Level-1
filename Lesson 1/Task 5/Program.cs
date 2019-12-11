using System;
using MyMethods;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, surname, city;
            name = WriterReader.WriteRead("Введите Ваше имя:");
            surname = WriterReader.WriteRead("Введите Вашу фамилию:");
            city = WriterReader.WriteRead("Введите Ваш город:");
            WriterReader.Print($"{name} {surname}, {city}", 
                (Console.WindowWidth-(3+name.Length+surname.Length+city.Length))/2, 
                Console.WindowHeight/2);
            Console.ReadKey();
        }
    }
}
