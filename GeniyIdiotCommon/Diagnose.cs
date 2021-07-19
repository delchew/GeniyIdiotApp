namespace GeniyIdiotCommon
{
    public static class Diagnose
    {
        public readonly static string[] Diagnoses = new string[]
        {
            "Идиот",
            "Кретин",
            "Дурак",
            "Нормальный",
            "Талант",
            "Гений"
        }; 

        public static UserResult GetUserDiagnose(User user, QuestionStorage questionStorage)
        {
            var diagnosePercentRange = 100.0 / (Diagnoses.Length - 1);
            var userPercentScore = 100.0 * user.CountRightAnswers / questionStorage.CountQuestions;
            var diagnoseIndex = 0;
            for (int i = diagnoseIndex; i < Diagnoses.Length; i++)
            {
                if (userPercentScore <= diagnosePercentRange * i)
                {
                    diagnoseIndex = i;
                    break;
                }
            }
            return new UserResult
            {
                UserName = user.Fio,
                CountRightAnswers = user.CountRightAnswers,
                Diagnose = Diagnoses[diagnoseIndex]
            };
        }
    }
}