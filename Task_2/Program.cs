using System;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
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
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
                sum += n;
            }
            Console.WriteLine($"Их сумма ровна: {sum}");
            Console.ReadKey();
        }
    }
}
