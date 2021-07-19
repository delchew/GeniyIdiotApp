namespace GeniyIdiotWinForms
{
    partial class StatisticForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticForm));
            this.statisticDataGridView = new System.Windows.Forms.DataGridView();
            this.fioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countRightAnswersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dianoseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeStatisticButton = new System.Windows.Forms.Button();
            this.statisticTabControl = new System.Windows.Forms.TabControl();
            this.tableTabPage = new System.Windows.Forms.TabPage();
            this.diagramTabPage = new System.Windows.Forms.TabPage();
            this.resultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.statisticDataGridView)).BeginInit();
            this.statisticTabControl.SuspendLayout();
            this.tableTabPage.SuspendLayout();
            this.diagramTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultChart)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticDataGridView
            // 
            this.statisticDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.statisticDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.statisticDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fioColumn,
            this.countRightAnswersColumn,
            this.dianoseColumn});
            this.statisticDataGridView.Location = new System.Drawing.Point(0, 0);
            this.statisticDataGridView.MultiSelect = false;
            this.statisticDataGridView.Name = "statisticDataGridView";
            this.statisticDataGridView.RowTemplate.ReadOnly = true;
            this.statisticDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.statisticDataGridView.Size = new System.Drawing.Size(533, 410);
            this.statisticDataGridView.TabIndex = 5;
            // 
            // fioColumn
            // 
            this.fioColumn.HeaderText = "ФИО";
            this.fioColumn.Name = "fioColumn";
            this.fioColumn.ReadOnly = true;
            this.fioColumn.Width = 200;
            // 
            // countRightAnswersColumn
            // 
            this.countRightAnswersColumn.HeaderText = "Число правильных ответов";
            this.countRightAnswersColumn.Name = "countRightAnswersColumn";
            this.countRightAnswersColumn.ReadOnly = true;
            this.countRightAnswersColumn.Width = 180;
            // 
            // dianoseColumn
            // 
            this.dianoseColumn.HeaderText = "Диагноз";
            this.dianoseColumn.Name = "dianoseColumn";
            this.dianoseColumn.ReadOnly = true;
            this.dianoseColumn.Width = 90;
            // 
            // closeStatisticButton
            // 
            this.closeStatisticButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeStatisticButton.Location = new System.Drawing.Point(460, 445);
            this.closeStatisticButton.Name = "closeStatisticButton";
            this.closeStatisticButton.Size = new System.Drawing.Size(75, 23);
            this.closeStatisticButton.TabIndex = 6;
            this.closeStatisticButton.Text = "Закрыть";
            this.closeStatisticButton.UseVisualStyleBackColor = true;
            this.closeStatisticButton.Click += new System.EventHandler(this.CloseStatisticButton_Click);
            // 
            // statisticTabControl
            // 
            this.statisticTabControl.Controls.Add(this.tableTabPage);
            this.statisticTabControl.Controls.Add(this.diagramTabPage);
            this.statisticTabControl.Location = new System.Drawing.Point(4, 3);
            this.statisticTabControl.Name = "statisticTabControl";
            this.statisticTabControl.SelectedIndex = 0;
            this.statisticTabControl.Size = new System.Drawing.Size(541, 436);
            this.statisticTabControl.TabIndex = 7;
            this.statisticTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.statisticTabControl_Selected);
            // 
            // tableTabPage
            // 
            this.tableTabPage.Controls.Add(this.statisticDataGridView);
            this.tableTabPage.Location = new System.Drawing.Point(4, 22);
            this.tableTabPage.Name = "tableTabPage";
            this.tableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tableTabPage.Size = new System.Drawing.Size(533, 410);
            this.tableTabPage.TabIndex = 0;
            this.tableTabPage.Text = "Статистика";
            this.tableTabPage.UseVisualStyleBackColor = true;
            // 
            // diagramTabPage
            // 
            this.diagramTabPage.Controls.Add(this.resultChart);
            this.diagramTabPage.Location = new System.Drawing.Point(4, 22);
            this.diagramTabPage.Name = "diagramTabPage";
            this.diagramTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.diagramTabPage.Size = new System.Drawing.Size(533, 410);
            this.diagramTabPage.TabIndex = 1;
            this.diagramTabPage.Text = "Диаграмма";
            this.diagramTabPage.UseVisualStyleBackColor = true;
            // 
            // resultChart
            // 
            chartArea1.Name = "ChartArea1";
            this.resultChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.resultChart.Legends.Add(legend1);
            this.resultChart.Location = new System.Drawing.Point(0, 0);
            this.resultChart.Name = "resultChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Диагнозы";
            this.resultChart.Series.Add(series1);
            this.resultChart.Size = new System.Drawing.Size(533, 410);
            this.resultChart.TabIndex = 0;
            this.resultChart.Text = "Результаты игр";
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 474);
            this.Controls.Add(this.statisticTabControl);
            this.Controls.Add(this.closeStatisticButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика игр";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statisticDataGridView)).EndInit();
            this.statisticTabControl.ResumeLayout(false);
            this.tableTabPage.ResumeLayout(false);
            this.diagramTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView statisticDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countRightAnswersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dianoseColumn;
        private System.Windows.Forms.Button closeStatisticButton;
        private System.Windows.Forms.TabControl statisticTabControl;
        private System.Windows.Forms.TabPage tableTabPage;
        private System.Windows.Forms.TabPage diagramTabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart resultChart;
    }
}