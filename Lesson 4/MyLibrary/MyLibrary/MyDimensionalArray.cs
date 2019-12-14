using System;
using System.IO;

namespace MyLibrary
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
    public class MyDimensionalArray
    {
        int[,] _array;
        public int Min
        {
            get
            {
                int min = 0;
                for (int i = 0; i < _array.GetLength(0); i++)
                {
                    for (int j = 0; j < _array.GetLength(1); j++)
                    {
                        if (_array[i, j] < min)
                        {
                            min = _array[i, j];
                        }
                    }
                }
                return min;
            }
        }
        public int Max
        {
            get
            {
                int max = 0;
                for (int i = 0; i < _array.GetLength(0); i++)
                {
                    for (int j = 0; j < _array.GetLength(1); j++)
                    {
                        if (_array[i, j] > max)
                        {
                            max = _array[i, j];
                        }
                    }
                }
                return max;
            }
        }
        public MyDimensionalArray()
        {
            AddRandomNumsInArray();
        }
        public MyDimensionalArray(string path)
        {
            if (File.Exists(path))
            {
                _array = new int[File.ReadAllLines(path).Length, File.ReadAllLines(path)[0].Split(' ').Length];
                StreamReader sr = new StreamReader(path);
                for (int i = 0; i < _array.GetLength(0); i++)
                {
                    int[] tempArr = Array.ConvertAll(sr.ReadLine().Split(' '), x => Convert.ToInt32(x));
                    for (int j = 0; j < _array.GetLength(1); j++)
                    {
                        _array[i, j] = tempArr[j];
                    }
                }
                sr.Close();
            }
            else
            {
                AddRandomNumsInArray();
                Console.WriteLine("Файл ненайден, массив заполнен случайными числами");
            }
        }
        public void WriteArrayToFile(string path)
        {
            StreamWriter sw = new StreamWriter(path, false);
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    if (j < _array.GetLength(1) - 1)
                    {
                        sw.Write($"{_array[i, j]} ");
                    }
                    else
                    {
                        sw.Write($"{_array[i, j]}");
                        sw.WriteLine();
                    }

                }
            }
            sw.Close();
        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    sum += _array[i, j];
                }
            }
            return sum;
        }
        public int Sum(int minElement)
        {
            int sum = 0;
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    if (_array[i, j] > minElement)
                    {
                        sum += _array[i, j];
                    }
                }
            }
            return sum;
        }
        public void IndexOfMax(ref int indexDim0, ref int indexDim1)
        {
            int max = 0;
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    if (_array[i, j] > max)
                    {
                        max = _array[i, j];
                        indexDim0 = i;
                        indexDim1 = j;
                    }
                }
            }
        }
        void AddRandomNumsInArray()
        {
            Random rnd = new Random();
            _array = new int[rnd.Next(4, 11), rnd.Next(4, 11)];
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    _array[i, j] = rnd.Next(0, 51);
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    if (j < _array.GetLength(1) - 1)
                    {
                        Console.Write($"{_array[i, j],3}");
                    }
                    else
                    {
                        Console.Write($"{_array[i, j],3}");
                        Console.WriteLine();
                    }

                }
            }
        }
    }
}
