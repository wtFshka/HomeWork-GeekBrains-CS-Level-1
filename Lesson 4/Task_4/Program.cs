using System;

namespace Task_4
{
    class Program
    {
        //Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
        //Создайте структуру Account, содержащую Login и Password.
        static void Main()
        {
            string login, password;
            int count = 0;
            Account acc;
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
                acc = new Account(login, password);
                if (acc.Authentication())
                {
                    Console.WriteLine("Добро пожаловать!");
                }
            } while (!acc.Authentication());
            Console.ReadKey();
        }
    }
}
