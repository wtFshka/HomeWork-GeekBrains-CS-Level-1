using System;

namespace Task_3
{
    class Program
    {
        //*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
        //Предусмотреть методы сложения, вычитания, умножения и деления дробей.
        //Написать программу, демонстрирующую все разработанные элементы класса.
        //* Добавить свойства типа int для доступа к числителю и знаменателю;
        //* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
        //**Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
        //*** Добавить упрощение дробей.
        static void Main(string[] args)
        {
            DecimalNumber dn1, dn2, dn3 = new DecimalNumber();
            Console.WriteLine($"Программа для арефметических операций с дробными числами.");
            Console.Write("Введите числитель первой дроби: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите знаминатель первой дроби: ");
            int b = Convert.ToInt32(Console.ReadLine());
            dn1 = new DecimalNumber(a, b);
            Console.Write("Введите числитель второй дроби: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите знаминатель второй дроби: ");
            b = Convert.ToInt32(Console.ReadLine());
            dn2 = new DecimalNumber(a, b);
            Console.WriteLine($"Для сложения нажмите на клавишу \"+\", для вычитания \"-\", для умножения \"*\", для деления \"/\"");
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Add:
                        dn3 = DecimalNumber.Plus(dn1, dn2);
                        Console.WriteLine($"Результат сложения дробных чилес равен: {dn3.Print()}");
                        break;
                    case ConsoleKey.Subtract:
                        dn3 = DecimalNumber.Minus(dn1, dn2);
                        Console.WriteLine($"Результат вычитания дробных чилес равен: {dn3.Print()}");
                        break;
                    case ConsoleKey.Multiply:
                        dn3 = DecimalNumber.Multi(dn1, dn2);
                        Console.WriteLine($"Результат деления дробных чилес равен: {dn3.Print()}");
                        break;
                    case ConsoleKey.Divide:
                        dn3 = DecimalNumber.Division(dn1, dn2);
                        Console.WriteLine($"Результат деления дробных чилес равен: {dn3.Print()}");
                        break;
                    default:
                        Console.WriteLine("Вы не нажали кнопку для проведения арефмитической операции с дробными числами, попробуйте ещё раз или нажмите Esc для выхода.");
                        break;
                }
            } while (key.Key != ConsoleKey.Add && key.Key != ConsoleKey.Subtract && key.Key != ConsoleKey.Multiply && key.Key != ConsoleKey.Divide && key.Key != ConsoleKey.Escape);
            if (key.Key == ConsoleKey.Add || key.Key == ConsoleKey.Subtract || key.Key == ConsoleKey.Multiply || key.Key == ConsoleKey.Divide)
            {
                Console.WriteLine("Для упрощения дроби нажмите \"Enter\", для перевода в десятичное число нажмите \"Пробел\", для выхода нажмите \"Esc\"");
                do
                {
                    key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.Enter:
                            dn3.Simplifying();
                            break;
                        case ConsoleKey.Spacebar:
                            Console.WriteLine($"Дробь {dn3.Numerator}/{dn3.Denumerator} переведена в десятичное число: {dn3.DecimalNum}");
                            break;
                        case ConsoleKey.Escape:
                            break;
                        default:
                            Console.WriteLine("Для упрощения дроби нажмите \"Enter\", для перевода в десятичное число нажмите \"Пробел\", для выхода нажмите \"Esc\"");
                            break;
                    } 
                } while (key.Key != ConsoleKey.Escape);
            }
            Console.ReadKey();
        }
    }
}
