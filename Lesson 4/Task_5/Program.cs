using MyLibrary;
using System;

namespace Task_5
{
    class Program
    {
        //5. *а) Реализовать библиотеку с классом для работы с двумерным массивом.
        //Реализовать конструктор, заполняющий массив случайными числами.
        //Создать методы, которые возвращают сумму всех элементов массива,
        //сумму всех элементов массива больше заданного, 
        //свойство, возвращающее минимальный элемент массива,
        //свойство, возвращающее максимальный элемент массива, 
        //метод, возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out).

        //**б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
        //**в) Обработать возможные исключительные ситуации при работе с файлами.
        static void Main()
        {
            Console.WriteLine("Программа для работы с двумерным массивом");
            MyDimensionalArray arr = new MyDimensionalArray();
            arr.WriteArrayToFile("WriteArrayToFile.txt");
            arr.Print();
            Console.WriteLine($"Min = {arr.Min}, Max = {arr.Max}, Sum = {arr.Sum()}, Sum > 10 = {arr.Sum(10)}");
            int indexDim0 = 0, indexDim1 = 1;
            arr.IndexOfMax(ref indexDim0, ref indexDim1);
            Console.WriteLine($"Index max number = [{indexDim0} , {indexDim1}]");
            Console.ReadKey();
        }
    }
}
