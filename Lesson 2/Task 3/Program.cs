using System;

namespace Task_3
{
    class Program
    {
        //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для вывода суммы введенных нечетных положительных чисел");
            int num, sum = 0;
            do
            {
                Console.Write("Введите чиcло, для выхода введите 0: ");
                num = Convert.ToInt32(Console.ReadLine().Replace('.', ','));
                if (num > 0 && num%2 == 1)
                {
                    sum += num;
                }
            } while (num != 0);
            Console.WriteLine($"суммы введенных нечетных положительных чисел ровна: {sum}");
            Console.ReadKey();
        }
    }
}
