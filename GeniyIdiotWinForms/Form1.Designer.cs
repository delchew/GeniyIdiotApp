namespace GeniyIdiotWinForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.startGamebutton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AbortGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вопросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.storageInfolabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.timeInfoLabel = new System.Windows.Forms.Label();
            this.timeOutLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.Enabled = false;
            this.nextQuestionButton.Location = new System.Drawing.Point(437, 324);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(80, 25);
            this.nextQuestionButton.TabIndex = 0;
            this.nextQuestionButton.Text = "Далее";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            this.nextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // startGamebutton
            // 
            this.startGamebutton.Location = new System.Drawing.Point(11, 324);
            this.startGamebutton.Name = "startGamebutton";
            this.startGamebutton.Size = new System.Drawing.Size(80, 25);
            this.startGamebutton.TabIndex = 1;
            this.startGamebutton.Text = "Новая игра";
            this.startGamebutton.UseVisualStyleBackColor = true;
            this.startGamebutton.Click += new System.EventHandler(this.StartGameEvent);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(6, 16);
            this.infoLabel.MaximumSize = new System.Drawing.Size(290, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(73, 13);
            this.infoLabel.TabIndex = 11;
            this.infoLabel.Text = "Информация";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameMenuItem,
            this.вопросыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(529, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameMenuItem
            // 
            this.gameMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameToolStripMenuItem,
            this.AbortGameToolStripMenuItem,
            this.statisticToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.gameMenuItem.Name = "gameMenuItem";
            this.gameMenuItem.Size = new System.Drawing.Size(43, 20);
            this.gameMenuItem.Text = "Игра";
            // 
            // NewGameToolStripMenuItem
            // 
            this.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem";
            this.NewGameToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.NewGameToolStripMenuItem.Text = "Новая игра";
            this.NewGameToolStripMenuItem.Click += new System.EventHandler(this.StartGameEvent);
            // 
            // AbortGameToolStripMenuItem
            // 
            this.AbortGameToolStripMenuItem.Name = "AbortGameToolStripMenuItem";
            this.AbortGameToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.AbortGameToolStripMenuItem.Text = "Прервать игру";
            this.AbortGameToolStripMenuItem.Click += new System.EventHandler(this.AbortGameToolStripMenuItem_Click);
            // 
            // statisticToolStripMenuItem
            // 
            this.statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            this.statisticToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.statisticToolStripMenuItem.Text = "Показать статистику";
            this.statisticToolStripMenuItem.Click += new System.EventHandler(this.StatisticToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.quitToolStripMenuItem.Text = "Выход";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // вопросыToolStripMenuItem
            // 
            this.вопросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadQuestionsToolStripMenuItem,
            this.AddQuestionToolStripMenuItem,
            this.CreateNewStorageToolStripMenuItem});
            this.вопросыToolStripMenuItem.Name = "вопросыToolStripMenuItem";
            this.вопросыToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.вопросыToolStripMenuItem.Text = "Вопросы";
            // 
            // loadQuestionsToolStripMenuItem
            // 
            this.loadQuestionsToolStripMenuItem.Name = "loadQuestionsToolStripMenuItem";
            this.loadQuestionsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.loadQuestionsToolStripMenuItem.Text = "Загрузить";
            this.loadQuestionsToolStripMenuItem.Click += new System.EventHandler(this.LoadQuestionsToolStripMenuItem_Click);
            // 
            // AddQuestionToolStripMenuItem
            // 
            this.AddQuestionToolStripMenuItem.Name = "AddQuestionToolStripMenuItem";
            this.AddQuestionToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.AddQuestionToolStripMenuItem.Text = "Добавить в текущую базу";
            this.AddQuestionToolStripMenuItem.Click += new System.EventHandler(this.AddQuestionToolStripMenuItem_Click);
            // 
            // CreateNewStorageToolStripMenuItem
            // 
            this.CreateNewStorageToolStripMenuItem.Name = "CreateNewStorageToolStripMenuItem";
            this.CreateNewStorageToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.CreateNewStorageToolStripMenuItem.Text = "Создать новую базу";
            this.CreateNewStorageToolStripMenuItem.Click += new System.EventHandler(this.CreateNewStorageToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.infoLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 122);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.storageInfolabel);
            this.groupBox2.Location = new System.Drawing.Point(318, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 122);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // storageInfolabel
            // 
            this.storageInfolabel.AutoSize = true;
            this.storageInfolabel.Location = new System.Drawing.Point(7, 20);
            this.storageInfolabel.Margin = new System.Windows.Forms.Padding(0);
            this.storageInfolabel.MaximumSize = new System.Drawing.Size(195, 0);
            this.storageInfolabel.Name = "storageInfolabel";
            this.storageInfolabel.Size = new System.Drawing.Size(149, 26);
            this.storageInfolabel.TabIndex = 10;
            this.storageInfolabel.Text = "Инфо о загрузке базы и ее названии";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.questionTextLabel);
            this.groupBox3.Location = new System.Drawing.Point(12, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 94);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Location = new System.Drawing.Point(9, 20);
            this.questionTextLabel.MaximumSize = new System.Drawing.Size(290, 0);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(113, 13);
            this.questionTextLabel.TabIndex = 10;
            this.questionTextLabel.Text = "Вопросы и диагнозы";
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.Enabled = false;
            this.userAnswerTextBox.Location = new System.Drawing.Point(89, 266);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(349, 20);
            this.userAnswerTextBox.TabIndex = 2;
            this.userAnswerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserAnswerTextBox_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.timeOutLabel);
            this.groupBox4.Controls.Add(this.timeInfoLabel);
            this.groupBox4.Location = new System.Drawing.Point(319, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 94);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // timeInfoLabel
            // 
            this.timeInfoLabel.AutoSize = true;
            this.timeInfoLabel.Location = new System.Drawing.Point(9, 20);
            this.timeInfoLabel.Name = "timeInfoLabel";
            this.timeInfoLabel.Size = new System.Drawing.Size(106, 13);
            this.timeInfoLabel.TabIndex = 0;
            this.timeInfoLabel.Text = "Осталось времени:";
            // 
            // timeOutLabel
            // 
            this.timeOutLabel.AutoSize = true;
            this.timeOutLabel.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeOutLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.timeOutLabel.Location = new System.Drawing.Point(12, 37);
            this.timeOutLabel.Name = "timeOutLabel";
            this.timeOutLabel.Size = new System.Drawing.Size(48, 24);
            this.timeOutLabel.TabIndex = 1;
            this.timeOutLabel.Text = "time";
            // 
            // MainForm
            // 
            this.AcceptButton = this.nextQuestionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 361);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.startGamebutton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Гений - Идиот\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.Button startGamebutton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGameToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label storageInfolabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox userAnswerTextBox;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.ToolStripMenuItem вопросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateNewStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AbortGameToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label timeOutLabel;
        private System.Windows.Forms.Label timeInfoLabel;
    }
}

