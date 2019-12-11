using MyMethods;
using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name, surname, age, height, weight;
            name = WriterReader.WriteRead("Введите Ваше имя:");
            surname = WriterReader.WriteRead("Введите Вашу фамилию:");
            age = WriterReader.WriteRead("Введите Ваш возраст:");
            height = WriterReader.WriteRead("Введите Ваш рост:");
            weight = WriterReader.WriteRead("Введите Ваш вес:");

            Console.WriteLine();
            Console.WriteLine("Метод склеивания:");
            Console.WriteLine("Имя: " + name + " Фамилия: " + surname + " Возраст: " + age + " Рост: " + height + " Вес: " + weight);
            Console.WriteLine("Форматированный вывод:");
            Console.WriteLine("Имя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес: {4}", name, surname, age, height, weight);
            Console.WriteLine("Метод интерполяции:");
            Console.WriteLine($"Имя: {name} Фамилия: {surname} Возраст: {age} Рост: {height} Вес: {weight}");
            Console.ReadKey();
        }
    }
}
