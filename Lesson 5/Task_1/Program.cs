using System;
using System.Text.RegularExpressions;

namespace Task_1
{
    class Program
    {
        //Создать программу, которая будет проверять корректность ввода логина.
        //Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
        //при этом цифра не может быть первой:
        //а) без использования регулярных выражений;
        //б) **с использованием регулярных выражений.
        static void Main()
        {
            Console.WriteLine("Введите Логин от 2 до 10 символов, содержащий только буквы латинского " +
                "алфавита или цифры, при этом цифра не может быть первой.");
            string login = Console.ReadLine();
            Console.WriteLine($"Обычная проверка: {(CheckLogin(login)?"подходит":"не подходит")}");
            Console.WriteLine($"Поверка через регулярные выражения: {(CheckLoginRegex(login)?"подходит":"не подходит")}");
            Console.ReadKey();

        }
        static bool CheckLogin(string login)
        {
            if (!char.IsDigit(login[0]) && login.Length > 1 && login.Length < 10)
            {
                foreach (var c in login)
                {
                    if (!char.IsDigit(c) && (c < 'a' || c > 'z') && (c < 'A' || c > 'Z'))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool CheckLoginRegex(string login) => Regex.IsMatch(login, @"^[a-zA-Z]{1}[a-zA-Z0-9]{1,8}$");
    }
}
