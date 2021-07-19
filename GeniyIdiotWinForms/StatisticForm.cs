using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GeniyIdiotCommon;

namespace GeniyIdiotWinForms
{
    public partial class StatisticForm : Form
    {
        private List<UserResult> userResults;
        private bool diagramLoad = false;

        public StatisticForm()
        {
            InitializeComponent();
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            userResults = FileProvider.GetUsersResults();
            FillStatisticTable();
        }

        private void FillStatisticTable()
        {
            foreach (var result in userResults)
            {
                statisticDataGridView.Rows.Add(result.UserName, result.CountRightAnswers, result.Diagnose);
            }
        }

        private void DrawDiagram()
        {
            var countDiagnosesDict = Diagnose.Diagnoses.ToDictionary(x => x, v => 0);

            foreach (var result in userResults)
            {
                countDiagnosesDict[result.Diagnose]++;
            }

            foreach (var diagnose in Diagnose.Diagnoses)
            {
                resultChart.Series["Диагнозы"].Points.AddXY(diagnose, countDiagnosesDict[diagnose]);
            }
        }

        private void CloseStatisticButton_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void statisticTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1 && !diagramLoad)
            {
                DrawDiagram();
                diagramLoad = true;
            }
        }
    }
}
