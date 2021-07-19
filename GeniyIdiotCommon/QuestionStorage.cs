using System.Collections.Generic;
using System.IO;
using System;
using Newtonsoft.Json;

namespace GeniyIdiotCommon
{
    public class QuestionStorage
    {
        private readonly List<Question> questions;
        public bool IsLoadSuccessfully { get; }
        public int CountQuestions { get; }
        public int RemainQuestions
        {
            get
            {
                return questions.Count;
            }
        }
        
        public QuestionStorage(string dataQuestionsPath)
        {
            List<Question> questionList;
            if (File.Exists(dataQuestionsPath))
            {
                questionList = JsonConvert.DeserializeObject<List<Question>>(File.ReadAllText(dataQuestionsPath));
                if (questionList == null || questionList.Count == 0)
                {
                    IsLoadSuccessfully = false;
                    return;
                }
                else
                {
                    foreach(var question in questionList)
                    {
                        if (string.IsNullOrEmpty(question.Text) || question.Answer == 0)
                        {
                            IsLoadSuccessfully = false;
                            return;
                        }
                    }
                }
                questions = questionList;
                CountQuestions = questions.Count;
                IsLoadSuccessfully = true;
            }
            else
            {
                IsLoadSuccessfully = false;
            }
        }

        public string GetQuestion(int index)
        {
            return questions[index].Text;
        }

        public int GetAnswer(int index)
        {
            return questions[index].Answer;
        }

        public void QuestionIsAnswered(int index)
        {
            questions.RemoveAt(index);
        }
    }
}
