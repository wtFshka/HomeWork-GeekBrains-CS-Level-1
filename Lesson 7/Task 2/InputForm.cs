using System;
using System.Windows.Forms;

namespace Task_2
{
    public partial class InputForm : Form
    {
        GuessTheNumber game;
        public InputForm(GuessTheNumber game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbAnswer.Text, out int answer))
            {
                game.Attempt(answer);
                this.Close();
            }
            else
            {
                MessageBox.Show("Мне кажется там написано не число...");
            }    
        }
    }
}
