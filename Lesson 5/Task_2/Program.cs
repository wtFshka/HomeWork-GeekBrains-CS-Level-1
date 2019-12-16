using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        //Разработать статический класс Message, содержащий следующие статические методы для
        //обработки текста:
        //а) Вывести только те слова сообщения, которые содержат не более n букв.
        //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        //в) Найти самое длинное слово сообщения.
        //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        //д) ***Создать метод, который производит частотный анализ текста.В качестве параметра в
        //него передается массив слов и текст, в качестве результата метод возвращает сколько раз
        //каждое из слов массива входит в этот текст.Здесь требуется использовать класс Dictionary.
        static void Main()
        {
            string[] words = new string[] { "задач", "менее", "машина", "не", "том" };
            string text = "Стандартный класс string позволяет выполнять над строками различные операции, в том числе поиск, " +
                "замену, вставку и удаление подстрок. Тем не менее есть классы задач по обработке символьной " +
                "информации, где стандартных возможностей явно не хватает. Чтобы облегчить решение подобных " +
                "задач, в .Net Framework встроен более мощный аппарат работы со строками, основанный на регулярных выражениях.";
            Console.WriteLine("Программа для работы с текстом. Дан текст: ");
            Console.WriteLine(text);
            Console.WriteLine();
            Console.Write("И массив слов к нему: ");
            foreach (var word in words)
            {
                Console.Write($"{word}; ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("В этом тексте слова из массива повторяются следующие количесвто раз:");           
            Console.WriteLine(" Слово | Количество ");
            Console.WriteLine("-------|------------");
            foreach (var word in Message.CounterWords(words, text))
            {
                Console.WriteLine($"{word.Key,6} | {word.Value,5}");
            }
            Console.WriteLine();
            Console.WriteLine($"Самое длинное слово текста: {Message.MaxLengthWords(text)}");
            Console.WriteLine();
            Console.WriteLine($"Текст, без слов заканчивающихся на букву \"е\":");
            Console.WriteLine(Message.DeleteWords(text, 'е'));
            Console.WriteLine();
            Console.WriteLine($"Текст, без слов которые длиннее 5 букв :");
            Console.WriteLine(Message.GetWords(text, 5));
            Console.ReadKey();
        }

    }
}
