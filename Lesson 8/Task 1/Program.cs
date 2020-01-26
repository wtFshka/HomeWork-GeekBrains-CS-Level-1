using System;
using System.Reflection;

namespace Task_1
{
    class Program
    {
        //1. С помощью рефлексии выведите все свойства структуры DateTime
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            var propdt = dt.GetType().GetRuntimeProperties();
            foreach (var prop in propdt)
            {
                Console.WriteLine(prop.Name);
            }
            Console.ReadKey();
        }
    }
}
