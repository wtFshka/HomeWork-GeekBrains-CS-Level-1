using System;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        GuessTheNumber game;
        public Form1()
        {
            InitializeComponent();
            game = new GuessTheNumber();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            InputForm frm = new InputForm(game);
            frm.ShowDialog();
            if (game.EndGame)
            {
                game = new GuessTheNumber();
                MessageBox.Show("Я загадал новое число от 1 до 100, удачи!");
            }
        }
    }
}
