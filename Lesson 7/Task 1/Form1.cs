using System;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        Doubler game;
        public Form1()
        {
            InitializeComponent();
            game = new Doubler();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            game.Plus();
            if (game.EndGame) game = new Doubler();
            this.lblValue.Text = game.Value;
            this.lblCount.Text = $"Попытка: {game.Count}";
        }
        private void btnMulti_Click(object sender, EventArgs e)
        {
            game.Multi();
            if (game.EndGame) game = new Doubler();
            this.lblValue.Text = game.Value;
            this.lblCount.Text = $"Попытка: {game.Count}";
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiNewGame_Click(object sender, EventArgs e)
        {
            game = new Doubler();
            this.lblValue.Text = game.Value;
            this.lblCount.Text = $"Попытка: {game.Count}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            game.Clear();
            this.lblValue.Text = game.Value;
            this.lblCount.Text = $"Попытка: {game.Count}";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            game.Cancel();
            this.lblValue.Text = game.Value;
            this.lblCount.Text = $"Попытка: {game.Count}";
        }
    }
}
