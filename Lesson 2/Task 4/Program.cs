using System;

namespace Task_4
{
    class Program
    {
        //Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
        //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
        //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
        //программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
        static void Main(string[] args)
        {
            string login, password;
            int count = 0;
            do
            {
                count++;
                if (count > 1)
                {
                    if (count > 3)
                    {
                        Console.WriteLine("3 раза введен не верный логин или пароль. Доступ закрыт.");
                        break;
                    }
                    Console.WriteLine("Введён не верный логин или паролью");
                }
                Console.Write("Введите логин: ");
                login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                password = Console.ReadLine();
                if (Auth(login, password))
                {
                    Console.WriteLine("Добро пожаловать!");
                }
            } while (!Auth(login, password));
            Console.ReadKey();
        }
        static bool Auth(string login, string password) => login == "root" && password == "GeekBrains";

    }
}
