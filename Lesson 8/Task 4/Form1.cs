using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Task_4
{
    public partial class mainForm : Form
    {
        List<BirthdayDataBase> database;
        BindingSource bs = new BindingSource();
        public mainForm()
        {
            database = new List<BirthdayDataBase>();
            InitializeComponent();
            bs.DataSource = database;
            dgvDataBase.DataSource = bs;
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "XML Файлы|*.xml" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (new FileInfo(ofd.FileName).Length < 10485760)
                {
                    database = BirthdayDataBase.Load(ofd.FileName);
                    bs.DataSource = database;
                }
                else
                {
                    MessageBox.Show($"Выбранный файл больше 10 Мб", "Внимание!");
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (database != null && database.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog() { Filter = "XML Файлы|*.xml" };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    BirthdayDataBase.Save(sfd.FileName, database);
                }
            }
            else
            {
                MessageBox.Show($"Нечего сохронять :(", "Внимание!");
            }
        }

        private void BtnAddRow_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                database.Add(new BirthdayDataBase());
            }
            else
            {
                MessageBox.Show($"Нету базы данных", "Внимание!");
            }
        }

        private void DgvDataBase_DataMemberChanged(object sender, EventArgs e)
        {
            database = new List<BirthdayDataBase>();
            foreach (DataGridViewRow row in dgvDataBase.Rows)
            {
                database.Add(new BirthdayDataBase((string)row.Cells[0].Value, (string)row.Cells[1].Value, (DateTime)row.Cells[2].Value));
            }
        }
    }
}
