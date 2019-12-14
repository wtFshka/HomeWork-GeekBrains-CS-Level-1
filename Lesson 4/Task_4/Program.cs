using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        //Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
        //Создайте структуру Account, содержащую Login и Password.
        static void Main()
        {
            File.WriteAllText("accounts.txt", "root GeekBrains");
        }

    }
    public struct Account
    {
        string _login;
        string _password;
        public Account(string login, string password)
        {
            _login = login;
            _password = password;
        }
        public bool Authentication()
        {
            string[] LogPassPairs = File.ReadAllLines("accounts.txt");
            foreach (var lp in LogPassPairs)
            {
                if (lp.Split(' ')[0] == _login && lp.Split(' ')[1] == _password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
