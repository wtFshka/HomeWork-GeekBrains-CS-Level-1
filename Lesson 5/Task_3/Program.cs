using System;
using System.Collections.Generic;

namespace Task_3
{
    class Program
    {
        //*Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
        //Например:
        //badc являются перестановкой abcd .
        static void Main()
        {
            Console.WriteLine("Программа для определения, является ли одна строка перестановкой другой");
            Console.Write("Введите первую строку: ");
            string word1 = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string word2 = Console.ReadLine();
            Console.WriteLine(WordCompair(word1, word2)?"Да, является":"Нет, не является");
            Console.ReadKey();
        }
        static bool WordCompair(string word1, string word2)
        {
            int sum = 0;
            Dictionary<char, int> coutnerChar = new Dictionary<char, int>();
            foreach (var w in word1)
            {
                if (coutnerChar.ContainsKey(w))
                {
                    coutnerChar[w]++;
                }
                else
                {
                    coutnerChar.Add(w, 1);
                }
            }
            foreach (var w in word2)
            {
                if (coutnerChar.ContainsKey(w))
                {
                    coutnerChar[w]--;
                }
            }
            foreach (var v in coutnerChar)
            {
                sum += v.Value;
            }
            return sum == 0;
        }
    }
}
