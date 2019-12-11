using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex_1 = new Complex(2, 3);
            Complex complex_2 = new Complex(7, 4);
            Complex complex_3;
            Console.WriteLine($"Программа для арефметических операций с комплексными числами, первое число равно {complex_1.Print()}, второе равно {complex_2.Print()}");
            Console.WriteLine($"Для сложения нажмите на клавишу \"+\", для вычитания \"+\", для умножения \"*\", для деления \"/\"");
            ConsoleKeyInfo key; 
            do
            {
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Add:
                        complex_3 = Complex.Plus(complex_1, complex_2);
                        Console.WriteLine($"Результат сложения комплексных чилес равен: {complex_3.Print()}");
                        break;
                    case ConsoleKey.Subtract:
                        complex_3 = Complex.Minus(complex_1, complex_2);
                        Console.WriteLine($"Результат вычитания комплексных чилес равен: {complex_3.Print()}");
                        break;
                    case ConsoleKey.Multiply:
                        complex_3 = Complex.Multi(complex_1, complex_2);
                        Console.WriteLine($"Результат деления комплексных чилес равен: {complex_3.Print()}");
                        break;
                    case ConsoleKey.Divide:
                        complex_3 = Complex.Division(complex_1, complex_2);
                        Console.WriteLine($"Результат деления комплексных чилес равен: {complex_3.Print()}");
                        break;
                    default:
                        Console.WriteLine("Вы не нажали кнопку для проведения арефмитической операции с комплексными числами, попробуйте ещё раз или нажмите Esc для выхода.");
                        break;
                }
            } while (key.Key != ConsoleKey.Add && key.Key != ConsoleKey.Subtract && key.Key != ConsoleKey.Multiply && key.Key != ConsoleKey.Divide && key.Key != ConsoleKey.Escape);
            Console.ReadKey();
        }
    }
}
