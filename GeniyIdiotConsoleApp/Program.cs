using System;
using GeniyIdiotCommon;

namespace GeniyIdiotConsoleApp
{
    class Program
    {
        static void Main()
        {
            do
            {
                var questionStorage = new QuestionStorage("DefaultQuestions.json");
                if(!questionStorage.IsLoadSuccessfully)
                {
                    ConsoleDialog.FileNotExistAlarm();
                    Environment.Exit(1);
                }
                var game = new Game(questionStorage);
                ConsoleDialog.StartInitialize();
                var user = new User(Console.ReadLine());
                ConsoleDialog.GetReady();
                game.Run(user);
                var userResult = Diagnose.GetUserDiagnose(user, questionStorage);
                ConsoleDialog.ShowDiagnose(userResult);
                FileProvider.AddUserResult(userResult);
                ConsoleDialog.AskAboutRepeatTest();
            }
            while (ConsoleDialog.ChooseYesOrNoKey());
            if(ConsoleDialog.ShowStatistic())
            {
                var statistic = FileProvider.GetUsersResults();
                foreach (var result in statistic)
                {
                    ConsoleDialog.PrintRowOfStatisticTable(result);
                }
            }
            ConsoleDialog.EndOfTest();
        }
    }
}
