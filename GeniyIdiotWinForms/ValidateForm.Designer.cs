namespace GeniyIdiotWinForms
{
    partial class ValidateForm
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
            this.InfoLabel = new System.Windows.Forms.Label();
            this.CancelValidButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(90, 25);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(109, 13);
            this.InfoLabel.TabIndex = 3;
            this.InfoLabel.Text = "Введите свои ФИО:";
            // 
            // CancelValidButton
            // 
            this.CancelValidButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelValidButton.Location = new System.Drawing.Point(13, 115);
            this.CancelValidButton.Name = "CancelValidButton";
            this.CancelValidButton.Size = new System.Drawing.Size(75, 23);
            this.CancelValidButton.TabIndex = 1;
            this.CancelValidButton.Text = "Отмена";
            this.CancelValidButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Enabled = false;
            this.OkButton.Location = new System.Drawing.Point(197, 115);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Далее";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(40, 65);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(200, 20);
            this.infoTextBox.TabIndex = 0;
            this.infoTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FioTextBox_KeyUp);
            // 
            // ValidateForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelValidButton;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.ControlBox = false;
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelValidButton);
            this.Controls.Add(this.InfoLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ValidateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Начать игру";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button CancelValidButton;
        private System.Windows.Forms.Button OkButton;
        internal System.Windows.Forms.TextBox infoTextBox;
    }
}