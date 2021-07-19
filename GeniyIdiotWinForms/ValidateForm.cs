using System.Windows.Forms;

namespace GeniyIdiotWinForms
{
    public partial class ValidateForm : Form
    {
        public ValidateForm(MainForm mainForm)
        {
            InitializeComponent();
        }

        private void FioTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if ((sender as TextBox).Text.Length == 0)
            {
                OkButton.Enabled = false;
            }
            else
            {
                OkButton.Enabled = true;
            }
        }
    }
}
