using GeniyIdiotCommon;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWinForms
{
    public partial class AddQuestionsForm : Form
    {
        private string addingFilePath;
        
        public AddQuestionsForm(string addingFilePath)
        {
            InitializeComponent();
            this.addingFilePath = addingFilePath;
        }

        private void answerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (questionTextBox.Text.Length == 0 || answerTextBox.Text.Length == 0)
            {
                addQuestionButton.Enabled = false;
            }
            else
            {
                addQuestionButton.Enabled = true;
            }
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            FileProvider.AddQuestion(addingFilePath, questionTextBox.Text, int.Parse(answerTextBox.Text));
            questionTextBox.Clear();
            answerTextBox.Clear();
            addQuestionButton.Enabled = false;
        }
    }
}
