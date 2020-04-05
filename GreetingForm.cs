using System;
using System.Windows.Forms;

namespace WitchOfAgnesi
{
    public partial class GreetingForm : Form
    {
        public GreetingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new MainForm();
            this.Close();
            Program.Context.MainForm.Show();
        }
    }
}
