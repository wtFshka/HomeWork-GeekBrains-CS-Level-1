using System;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form2 : Form
    {
        int count;
        public bool Auth { get; private set; }
        public Form2()
        {
            Auth = false;
            InitializeComponent();
            count = 0;
        }
        private void CheckLockPass()
        {
            if (tbLogin.Text == "root" && tbPassword.Text == "GeekBrains")
            {
                Auth = true;
                this.Close();
            }
            else
            {
                if (++count == 3)
                {
                    this.Close();
                }
            }
        }
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            CheckLockPass();
        }

        private void KeyDown_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckLockPass();
            }
        }
    }
}
