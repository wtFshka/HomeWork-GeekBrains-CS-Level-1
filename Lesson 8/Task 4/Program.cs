using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    static class Program
    {
        //*Используя полученные знания и класс TrueFalse в качестве шаблона, разработать
        //собственную утилиту хранения данных (Например: Дни рождения, Траты, Напоминалка,
        //Английские слова и другие).
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }
}
