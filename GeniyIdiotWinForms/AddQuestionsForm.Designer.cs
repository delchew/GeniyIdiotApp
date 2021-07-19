namespace GeniyIdiotWinForms
{
    partial class AddQuestionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuestionsForm));
            this.addQuestionButton = new System.Windows.Forms.Button();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endAddingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.Enabled = false;
            this.addQuestionButton.Location = new System.Drawing.Point(371, 210);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.addQuestionButton.TabIndex = 1;
            this.addQuestionButton.Text = "Добавить";
            this.addQuestionButton.UseVisualStyleBackColor = true;
            this.addQuestionButton.Click += new System.EventHandler(this.addQuestionButton_Click);
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(12, 33);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(435, 85);
            this.questionTextBox.TabIndex = 2;
            this.questionTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(12, 155);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(100, 20);
            this.answerTextBox.TabIndex = 3;
            this.answerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.answerTextBox_KeyPress);
            this.answerTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вопрос";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ответ (должен быть целым числом)";
            // 
            // endAddingButton
            // 
            this.endAddingButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.endAddingButton.Location = new System.Drawing.Point(12, 210);
            this.endAddingButton.Name = "endAddingButton";
            this.endAddingButton.Size = new System.Drawing.Size(75, 23);
            this.endAddingButton.TabIndex = 6;
            this.endAddingButton.Text = "Завершить";
            this.endAddingButton.UseVisualStyleBackColor = true;
            // 
            // AddQuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 245);
            this.Controls.Add(this.endAddingButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.addQuestionButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddQuestionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить вопрос";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addQuestionButton;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button endAddingButton;
    }
}