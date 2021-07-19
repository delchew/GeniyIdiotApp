using System;
using GeniyIdiotCommon;

namespace GeniyIdiotConsoleApp
{
    public static class ConsoleDialog
    {
        public static void StartInitialize()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            DrawSplitter();
            Console.WriteLine("-------------------------   Тест \"Гений - Идиот\"   -------------------------");
            DrawSplitter();
            Console.ResetColor();
            Console.WriteLine("Введите ФИО:");
        }

        static void FillTableRow(object column1, object column2, object column3)
        {
            Console.WriteLine("| {0, -35} | {1, -20} | {2, -11} |", column1, column2, column3);
        }
        
        public static void PrintRowOfStatisticTable(UserResult userResult)
        {
            FillTableRow(userResult.UserName, userResult.CountRightAnswers, userResult.Diagnose);
            DrawSplitter();
        }

        public static void PrintHeadOfStatisticTable()
        {
            Console.ResetColor();
            DrawSplitter();
            FillTableRow("ФИО", "Число верных ответов", "Диагноз");
            DrawSplitter();
        }

        public static void GetReady()
        {
            ShowRulesOfAnswer();
            Console.WriteLine("У вас будет по 10 секунд для ответа на каждый вопрос.\nНажмите любую клавишу для начала теста...");
            Console.ReadKey(true);
            DrawSplitter();
        }

       public static void PrintQuestionText(int questionIndex, QuestionStorage questionStorage)
        {
            Console.WriteLine(questionStorage.GetQuestion(questionIndex));
        }

        public static void PrintQuestionNumber(int questionIndex)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Вопрос N" + (questionIndex + 1));
            Console.ResetColor();
        }

        public static void AskAboutRepeatTest()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            DrawSplitter();
            Console.WriteLine();
            Console.WriteLine("Пройти тест снова? Да - Y, Нет - N");
        }

        public static bool ShowStatistic()
        {
            Console.WriteLine("Показать статистику? Да - Y, нет - N");
            if (ChooseYesOrNoKey())
            {
                PrintHeadOfStatisticTable();
                return true;
            }
            else
            {
                Console.WriteLine("Конец теста");
                Console.ResetColor();
                return false;
            }
        }

        public static void DrawSplitter() => Console.WriteLine("----------------------------------------------------------------------------");

        public static void ShowRulesOfAnswer() => Console.WriteLine("\nОтвет должен быть целым числом!\nИспользуйте только цифры и клавишу Enter для ввода ответа.");

        public static void SayTimeOut() => Console.WriteLine("\nВремя вышло...");
        public static void EndOfTest()
        {
            Console.WriteLine("Тест окончен. Для выхода из программы нажмите любую клавишу.");
            Console.ReadKey();
        }

        public static void FileNotExistAlarm()
        {
            Console.WriteLine("Отсутствует файл с базой вопросов для теста!\nПроверьте что файл должен лежать в одном каталоге вместе с исполняемым приложением!");
            Console.WriteLine("Для завершения программы нажмите любую клавишу...");
            Console.ReadKey();
        }

        public static bool ChooseYesOrNoKey()
        {
            while (true)
            {
                var keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Y:
                        return true;
                    case ConsoleKey.N:
                        return false;
                    default:
                        Console.WriteLine("Вы должны нажать клавишу Y если да и N если нет.");
                        break;
                }
            }
        }

        public static void CursorBack()
        {
            Console.Write(" ");
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }

        public static void ShowDiagnose(UserResult userResult)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Число правильных ответов: " + userResult.CountRightAnswers + ".");
            Console.WriteLine("Ваш диагноз: " + userResult.Diagnose);
        }
    }
}
