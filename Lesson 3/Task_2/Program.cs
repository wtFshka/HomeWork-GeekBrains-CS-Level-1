using System;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
            //Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.

            List<double> numbers = new List<double>();
            double num, sum = 0;
            Console.WriteLine("Программа посчета суммы всех введенных нечетных положительных чисел, для вывода результата и выхода из программы введите 0");
            do
            {
                if (double.TryParse(Console.ReadLine().Replace(',','.'), out num))
                {
                    if (num % 2 == 1 && num > 0)
                    {
                        numbers.Add(num); 
                    }
                } else
                {
                    Console.WriteLine("Что-то не похоже на число... Попробуйте ещё раз или ввидите 0");
                    num = -1;
                }    
            } while (num != 0);
            Console.WriteLine($"Вами было введено {numbers.Count} нечетных положительных чисел(а):");
            foreach (double n in numbers)
            {
                Console.WriteLine(n);
                sum += n;
            }
            Console.WriteLine($"Их сумма ровна: {sum}");
            Console.ReadKey();
        }
    }
}
