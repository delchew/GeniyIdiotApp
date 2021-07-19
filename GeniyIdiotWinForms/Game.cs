using GeniyIdiotCommon;
using System;
using System.IO;

namespace GeniyIdiotWinForms
{
    public class Game
    {
        private QuestionStorage questionStorage;
        private int randomQuestionIndex;
        internal User user;
        public string DataFileName { get; }
        public bool QuestionsLoaded { get; }
        public int CountQuestions
        {
            get
            {
                return questionStorage.CountQuestions;
            }
        }
        public bool QuestionsOver
        {
            get
            {
                return questionStorage.RemainQuestions == 0;
            }
        }

        public Game(string dataFilePath)
        {
            questionStorage = new QuestionStorage(dataFilePath);
            DataFileName = Path.GetFileName(dataFilePath);
            QuestionsLoaded = questionStorage.IsLoadSuccessfully;     
        }
        
        public void AddUser(User user)
        {
            this.user = user;
        }

        public string GetRandomQuestion()
        {
            randomQuestionIndex = GetRandomIndex(questionStorage.RemainQuestions);
            return questionStorage.GetQuestion(randomQuestionIndex); 
        }

        public int GetQuestionNumber()
        {
            return questionStorage.CountQuestions - questionStorage.RemainQuestions + 1;
        }

        private int GetRandomIndex(int countQuestions)
        {
            var random = new Random();
            return random.Next(0, countQuestions);
        }

        public void CheckUserAnswer(string userAnswer)
        {
            if (int.Parse(userAnswer) == questionStorage.GetAnswer(randomQuestionIndex))
            {
                user.CountRightAnswers++;
            }
            SkipQuestion();
        }

        public void SkipQuestion()
        {
            questionStorage.QuestionIsAnswered(randomQuestionIndex);
        }

        public UserResult GetUserResult()
        {
            return Diagnose.GetUserDiagnose(user, questionStorage);
        }
    }
}
