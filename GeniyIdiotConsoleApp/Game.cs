using System;
using System.Threading;
using GeniyIdiotCommon;

namespace GeniyIdiotConsoleApp
{
    public class Game
    {
        QuestionStorage questionStorage;
        public Game(QuestionStorage questionStorage)
        {
            this.questionStorage = questionStorage;
        }

        public void Run(User user)
        {
            var countQuestions = questionStorage.CountQuestions;
            for (int questionIndex = 0; questionIndex < countQuestions; questionIndex++)
            {
                ConsoleDialog.PrintQuestionNumber(questionIndex);
                var randomIndex = GetRandomIndex(questionStorage.RemainQuestions);
                ConsoleDialog.PrintQuestionText(randomIndex, questionStorage);
                var userAnswer = GetUserAnswer();
                if (userAnswer == questionStorage.GetAnswer(randomIndex))
                {
                    user.CountRightAnswers++;
                }
                questionStorage.QuestionIsAnswered(randomIndex);
            }
        }

        int GetUserAnswer()
        {
            bool answerReceived = false;
            bool timeOut = false;
            string stringUserAnswer;
            TimerCallback callBack = (object obj) => { ConsoleDialog.SayTimeOut(); stringUserAnswer = "-1"; timeOut = true; };
            using (var timer = new Timer(callBack, null, 10000, Timeout.Infinite))
            {
                stringUserAnswer = "";
                while (!timeOut && !answerReceived)
                {                    
                    if (Console.KeyAvailable)
                    {
                        var keyInfo = Console.ReadKey();
                        switch (keyInfo.Key)
                        {
                            case ConsoleKey.Enter:
                                answerReceived = !StringIsEmpty(stringUserAnswer);
                                break;

                            case ConsoleKey.Backspace:
                                stringUserAnswer = ClearLastSymbolInAnswer(stringUserAnswer);
                                break;

                            default:
                                stringUserAnswer = AddDigitSymbolInAnswer(keyInfo.KeyChar, stringUserAnswer);
                                break;
                        }
                    }
                }
            }
            return int.Parse(stringUserAnswer);
        }

        int GetRandomIndex(int countQuestions)
        {
            var random = new Random();
            return random.Next(0, countQuestions);
        }

        bool StringIsEmpty(string stringUserAnswer)
        {
            if (stringUserAnswer.Length > 0)
            {
                Console.WriteLine();
                return false;
            }
            else
            {
                ConsoleDialog.ShowRulesOfAnswer();
                return true;
            }
        }

        string ClearLastSymbolInAnswer(string stringAnswer)
        {
            if (stringAnswer.Length > 0)
            {
                ConsoleDialog.CursorBack();
                stringAnswer = stringAnswer.Remove(stringAnswer.Length - 1);
            }
            return stringAnswer;
        }

        string AddDigitSymbolInAnswer(char symbol, string stringAnswer)
        {
            if (char.IsDigit(symbol))
            {
                stringAnswer += symbol;
            }
            else
            {
                stringAnswer = "";
                ConsoleDialog.ShowRulesOfAnswer();
            }
            return stringAnswer;
        }
    }
}
