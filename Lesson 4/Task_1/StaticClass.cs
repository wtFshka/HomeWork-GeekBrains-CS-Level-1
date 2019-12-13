using System;
using System.IO;

namespace Task_1_2
{
    public static class StaticClass
    {
        public static int[] GetArrayFromFile(string filename)
        {
            if (File.Exists(filename))
            {
                return Array.ConvertAll(File.ReadAllLines(filename), x => Convert.ToInt32(x));
            }
            else
            {
                return CreatRandomArray();
            }
        }

        public static int[] CreatRandomArray(int lenghtArray = 20)
        {
            int[] array = new int[lenghtArray];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10000, 10001);
            }
            return array;
        }
        public static void CreatRandomArray(string filename, int lenghtArray = 20)
        {
            int[] array = new int[lenghtArray];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10000, 10001);
            }
            File.WriteAllLines(filename, Array.ConvertAll(array, x => x.ToString()));
        }
        public static void FindPairs(int[] array)
        {
            int count = 0;
            if (array.Length > 1)
            {
                Console.Write($"Весь массив: ");
                foreach (int a in array)
                {
                    Console.Write($"{a}; ");
                }
                Console.WriteLine();
                for (int i = 0; i < array.Length-1; i++)
                {
                    if (array[i]%3==0 ^ array[i+1]%3==0)
                    {
                        Console.WriteLine($"{array[i]} и {array[i+1]}");
                        count++;
                    }
                }
                Console.WriteLine($"Всего подходящих пар: {count}");
            }
        }
    }
}
