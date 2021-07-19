using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeniyIdiotCommon
{
    public static class FileProvider
    {
        private static readonly string usersResultsfilePath = "statistic.json";
        public static void AddQuestion(string filePath, string text, int answer)
        {
            var question = new Question(text, answer);
            List<Question> questionList;
            if (File.Exists(filePath))
            {
                string loadText = File.ReadAllText(filePath);
                if (!string.IsNullOrEmpty(loadText))
                {
                    questionList = JsonConvert.DeserializeObject<List<Question>>(loadText);
                    questionList.Add(question);
                }
                else
                {
                    questionList = new List<Question> { question };
                }  
            }
            else
            {
                questionList = new List<Question> { question };
            }
            File.WriteAllText(filePath, JsonConvert.SerializeObject(questionList, Formatting.Indented), Encoding.UTF8);
        }

        public static void AddUserResult(UserResult userResult)
        {
            List<UserResult> statistic;
            if (File.Exists(usersResultsfilePath))
            {
                statistic = JsonConvert.DeserializeObject<List<UserResult>>(File.ReadAllText(usersResultsfilePath));
                statistic.Add(userResult);
            }
            else
            {
                statistic = new List<UserResult> { userResult };              
            }
            File.WriteAllText(usersResultsfilePath, JsonConvert.SerializeObject(statistic, Formatting.Indented), Encoding.UTF8);
        }

        public static List<UserResult> GetUsersResults()
        {
            if (File.Exists(usersResultsfilePath))
            {
                return JsonConvert.DeserializeObject<List<UserResult>>(File.ReadAllText(usersResultsfilePath));
            }
            return new List<UserResult>();
        }

        public static void CreateStorageFile(string fileName)
        {
            var sw = new StreamWriter(fileName, true, Encoding.UTF8);
            sw.Close();
            sw.Dispose();
        }
    }


}
