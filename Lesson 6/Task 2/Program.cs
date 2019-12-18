using System;

namespace Task_2
{
    //Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.

    //а) Сделать меню с различными функциями и представить пользователю выбор, для какой
    //функции и на каком отрезке находить минимум. Использовать массив(или список) делегатов,
    //в котором хранятся различные функции.
    //б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.
    //Пусть она возвращает минимум через параметр (с использованием модификатора out).
    class Program
    {
        static void Main()
        {
            int choice = 0;
            double min;
            Console.WriteLine("Программа для нахождения минимума функций");
            Func[] funcs = new Func[] { MinFunc.Func_1, MinFunc.Func_2, MinFunc.Func_3, MinFunc.Func_4 };
            Console.Write("Введите начало отрезка: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конец отрезка: ");
            int b = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Выбирите функцию, для выбора введите омер функции от 1 до 4: ");
                int.TryParse(Console.ReadLine(), out choice);
            } while (choice > 4 || choice < 1);

            MinFunc.SaveFunc("data.txt", a, b, 0.5, funcs[choice]);
            double[] stepsFunc = MinFunc.Load("data.txt", out min);
            Console.WriteLine($"Минимум функции под номером {choice} ранвен: {min}, сделано шагов: {stepsFunc.Length}");
            Console.ReadKey();
        }
    }

}
