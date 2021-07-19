namespace GeniyIdiotCommon
{
    public class User
    {
        public string Fio { get; set; }
        public int CountRightAnswers { get; set; }

        public User(string fio)
        {
            Fio = fio;
            CountRightAnswers = 0;
        }

    }
}
