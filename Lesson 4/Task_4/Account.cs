using System.IO;

namespace Task_4
{
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
            if (File.Exists("accounts.txt"))
            {
                string[] LogPassPairs = File.ReadAllLines("accounts.txt");
                foreach (var lp in LogPassPairs)
                {
                    if (lp.Split(' ')[0] == _login && lp.Split(' ')[1] == _password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
