using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbMain.DataBindings.Add("Text", this.nudMain, "Value");
        }
    }
}
