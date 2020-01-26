using System;
using System.IO;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        TrueFalse database;
        Form2 admForm;
        public Form1()
        {
            InitializeComponent();
        }
        public void Binding()
        {
            Binding bind = new Binding("Maximum", database, "Count") { DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged };
            nudQuestionIndex.DataBindings.Add(bind);
        }
        private void NextQ()
        {
            if (nudQuestionIndex.Value != database.Count)
            {
                nudQuestionIndex.Value++;
                return;
            }
            MessageBox.Show("Это был последний вопрос!", "Внимание!");
        }

        private void TsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsmiOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "XML Файлы|*.xml" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (new FileInfo(ofd.FileName).Length < 10485760)
                {
                    database = new TrueFalse(ofd.FileName);
                    nudQuestionIndex.Minimum = 1;
                    nudQuestionIndex.Maximum = database.Count;
                    nudQuestionIndex.Value = nudQuestionIndex.Minimum;
                }
                else
                {
                    MessageBox.Show($"Выбранный файл больше 10 Мб", "Внимание!");
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                database = new TrueFalse();
            }
            Form3 frmQuestionAdd = new Form3(database);
            frmQuestionAdd.ShowDialog();
            nudQuestionIndex.Maximum = database.Count;
            nudQuestionIndex.Minimum = 1;
        }

        private void NudQuestionIndex_ValueChanged(object sender, EventArgs e)
        {
            if (database.Count == 0 || database == null)
            {
                return;
            }
            tbQuestion.Text = database[Convert.ToInt32(nudQuestionIndex.Value)-1].Text;
            cbTrueFalse.Checked = database[Convert.ToInt32(nudQuestionIndex.Value)-1].TrueFalse;
        }

        private void CbTrueFalse_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nudQuestionIndex.DataBindings.Count; i++)
            {
                tbQuestion.Text += $" \r{nudQuestionIndex.DataBindings[i].BindableComponent} \r{nudQuestionIndex.DataBindings[i].DataSourceUpdateMode}";
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (database == null || database.Count == 0)
            {
                MessageBox.Show($"Нет базы вопросов", "Внимание!");
                return;
            }
            database.Remove((int)nudQuestionIndex.Value - 1);
            if (database.Count == 0)
            {
                tbQuestion.Text = "";
                nudQuestionIndex.Maximum = 0;
                nudQuestionIndex.Minimum = 0;
                return;
            }
            else if (nudQuestionIndex.Value > database.Count)
            {
                nudQuestionIndex.Value = database.Count;
            } 
            nudQuestionIndex.Maximum = database.Count;
            nudQuestionIndex.Value = nudQuestionIndex.Value;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (database != null && database.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog() { Filter = "XML Файлы|*.xml" };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    database.Save(sfd.FileName);
                }
            }
            else
            {
                MessageBox.Show($"Нечего сохронять :(", "Внимание!");
            }
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Программа верю - не верю", "Версия 0.001 pre alpha");
        }

        private void MsMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (admForm == null)
            {
                tsmiAdmin.Visible = true;
            }
        }

        private void TsmiAdmin_Click(object sender, EventArgs e)
        {
            admForm = new Form2();
            admForm.ShowDialog();
            if (admForm.Auth)
            {
                btnAdd.Visible = true;
                btnRemove.Visible = true;
                btnSave.Visible = true;
                cbTrueFalse.Visible = true;
                cbTrueFalse.Enabled = true;
                tbQuestion.ReadOnly = false;
            }
            tsmiAdmin.Visible = false;
        }

        private void BtnTrue_Click(object sender, EventArgs e)
        {
            if (database != null && database.Count > 0)
            {
                if (cbTrueFalse.Checked)
                {
                    MessageBox.Show($"Правильно!");
                }
                else
                {
                    MessageBox.Show($"Не правильно!");
                }
                NextQ();
            }
            else
            {
                MessageBox.Show($"Нет базы вопросов", "Внимание!");
            }
        }

        private void BtnFalse_Click(object sender, EventArgs e)
        {
            if (database != null && database.Count > 0)
            {
                if (!cbTrueFalse.Checked)
                {
                    MessageBox.Show($"Правильно!");
                }
                else
                {
                    MessageBox.Show($"Не правильно!");
                }
                NextQ();
            }
            else
            {
                MessageBox.Show($"Нет базы вопросов", "Внимание!");
            }
        }

        private void TbQuestion_TextChanged(object sender, EventArgs e)
        {
            if (database != null)
            {
                database[(int)nudQuestionIndex.Value-1].Text = tbQuestion.Text;
            }
        }

        private void CbTrueFalse_CheckedChanged(object sender, EventArgs e)
        {
            if (database != null)
            {
                database[(int)nudQuestionIndex.Value - 1].TrueFalse = cbTrueFalse.Checked;
            }
        }
    }
}
