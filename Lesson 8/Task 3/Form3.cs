using System;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form3 : Form
    {
        TrueFalse database;
        public Form3(TrueFalse database)
        {
            this.database = database;
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!database.Questions.Exists(x => x.Text == tbQuestion.Text))
            {
                database.Add(tbQuestion.Text, cbQuestion.Checked);
            }
            else
            {
                MessageBox.Show("Такой вопрос уже есть", "Внимание!");
            }
            this.Close();
        }
    }
}
