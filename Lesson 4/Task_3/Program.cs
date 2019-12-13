using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyArray;

namespace Task_3
{
    class Program
    {
        //а) Дописать класс для работы с одномерным массивом. 
        //Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
        //Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у
        //всех элементов массива (старый массив, остается без изменений), метод Multi, умножающий каждый элемент массива на определённое число,
        //свойство MaxCount, возвращающее количество максимальных элементов.
        //б)** Cоздать библиотеку содержащую класс для работы с массивом.
        //Продемонстрировать работу библиотеки 

        //е)*** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)

        static void Main()
        {
            Console.WriteLine("Программа для работы с массивом");
            MyArray.MyArray mr = new MyArray.MyArray(5, 3, 2);
            Console.Write($"Созданный массив: ");
            Console.WriteLine(mr);
            Console.WriteLine($"Сумма чисел массива: {mr.Sum}");
            int[] array = mr.Inverse();
            string strArr = "";
            foreach (var a in array)
            {
                strArr += $" {a}";
            }
            Console.Write($"Созданный массив с измененными знаками: ");
            Console.WriteLine(strArr);
            Console.Write($"Первый созданный массив: ");
            Console.WriteLine(mr);
            mr.Multi(2);
            Console.Write($"Первый массив с эелементами перемноженными на 2: ");
            Console.WriteLine(mr);
            Console.Write($"Количество максимальных чисел в первом массиве: ");
            Console.WriteLine(mr.MaxCount);
            Console.ReadKey();
        }
    }

}
