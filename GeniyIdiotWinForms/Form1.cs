using System;
using System.Windows.Forms;
using GeniyIdiotCommon;

namespace GeniyIdiotWinForms
{
    public partial class MainForm : Form
    {
        private Timer timer;
        private int secondsCounter;
        private Game game;
        private OpenFileDialog openFile;
        private SaveFileDialog saveFile;
        public string defaultFilePath = "DefaultQuestions.json";
        private readonly string rules = "В этой игре вы ответите на несколько незамысловатых вопросов и получите диагноз своих умственных способностей. " +
                                        "Не принимайте его близко к сердцу :) " +
                                        "Учтите, что все ответы - целые числа. " +
                                        "Вам будет дано по 10 сек для ответа на каждый из вопросов." +
                                        "Если вы готовы сыграть, нажмите кнопку \"Новая игра\".";
        public MainForm()
        {
            InitializeComponent();
            infoLabel.Text = rules;
            questionTextLabel.Text = "";
            timeInfoLabel.Text = "";
            timeOutLabel.Text = "";
            AbortGameToolStripMenuItem.Enabled = false;
            openFile = new OpenFileDialog
            {
                Filter = "(*.json)|*.json",
                InitialDirectory = Environment.CurrentDirectory,
                FileName = defaultFilePath
            };
            saveFile = new SaveFileDialog
            {
                Filter = "(*.json)|*.json",
                InitialDirectory = Environment.CurrentDirectory,
                CheckPathExists = true,
                AddExtension = true,
                FileName = "GeniyIdiotQuestions1",
                DefaultExt = "json",
            };
            saveFile.FileOk += SaveFile_FileOk;

            timer = new Timer
            {
                Interval = 1000
            };
            timer.Tick += Timer_Tick;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadGame();
        }

        private void Timer_Tick(object sender, EventArgs e)
        { 
            secondsCounter--;
            timeOutLabel.Text = secondsCounter.ToString();
            if (secondsCounter == 0)
            {
                game.SkipQuestion();
                if (GameIsOver()) timer.Stop();
                else AskNextQuestion();
            }
            
        }

        public void GameInitialize()
        {
            userAnswerTextBox.Enabled = true;
            startGamebutton.Enabled = false;
            nextQuestionButton.Enabled = true;
            userAnswerTextBox.Clear();
            statisticToolStripMenuItem.Enabled = false;
            AbortGameToolStripMenuItem.Enabled = true;
            loadQuestionsToolStripMenuItem.Enabled = false;
            CreateNewStorageToolStripMenuItem.Enabled = false;
            AddQuestionToolStripMenuItem.Enabled = false;
        }

        public void LoadGame()
        {
            game = new Game(defaultFilePath);
            ShowLoadGameInfo(game);
        }
        public void GameStart(User validUser)
        {
            game.AddUser(validUser);
            GameInitialize();
            timeInfoLabel.Text = "Осталось времени:";
            AskNextQuestion();
        }

        private void GameStop()
        {
            nextQuestionButton.Enabled = false;
            userAnswerTextBox.Clear();
            questionTextLabel.Text = "";
            timeInfoLabel.Text = "";
            timeOutLabel.Text = "";
            userAnswerTextBox.Enabled = false;
            startGamebutton.Enabled = true;
            statisticToolStripMenuItem.Enabled = true;
            loadQuestionsToolStripMenuItem.Enabled = true;
            AddQuestionToolStripMenuItem.Enabled = true;
            CreateNewStorageToolStripMenuItem.Enabled = true;
            AbortGameToolStripMenuItem.Enabled = false;
        }

        private void AskNextQuestion()
        {
            secondsCounter = 10;
            timeOutLabel.Text = secondsCounter.ToString();
            timer.Start();

            userAnswerTextBox.Clear();
            userAnswerTextBox.Focus();
            questionTextLabel.Text = game.GetRandomQuestion();
            infoLabel.Text = string.Format("Вопрос №{0}", game.GetQuestionNumber());
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            if (userAnswerTextBox.Text.Length == 0)
            {
                MessageBox.Show("Вы ничего не ввели. Напоминаем, что ответ должен быть целым числом и не может быть пустым.", "Введите ответ!");
                return;
            }
            timer.Stop();
            game.CheckUserAnswer(userAnswerTextBox.Text);
            if (GameIsOver()) return;
            AskNextQuestion();
        }

        private bool GameIsOver()
        {
            if (game.QuestionsOver)
            {
                GameStop();
                infoLabel.Text = "Игра окончена. Вам вынесен вердикт!";
                var userResult = game.GetUserResult();
                FileProvider.AddUserResult(userResult);
                questionTextLabel.Text = "Уважаемый " + userResult.UserName + ", число правильных ответов: " + userResult.CountRightAnswers + ".\nВаш диагноз: \"" + userResult.Diagnose + "\".";
                LoadGame();
                return true;
            }
            return false;
        }

        private void StatisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var statisticForm = new StatisticForm();
            statisticForm.ShowDialog(this);
        }

        private void LoadQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            defaultFilePath = openFile.FileName;
            LoadGame();
        }

        private void ShowLoadGameInfo (Game game)
        {
            if (game.QuestionsLoaded)
            {
                storageInfolabel.Text = "Загружена база вопросов:\n" + game.DataFileName + "\nЧисло вопросов: " + game.CountQuestions;
                startGamebutton.Enabled = true;
                NewGameToolStripMenuItem.Enabled = true;
            }
            else
            {
                storageInfolabel.Text = "База вопросов " + game.DataFileName + " отсутствует или загруженный файл со списком вопросов имеет неправильный формат.";
                startGamebutton.Enabled = false;
                NewGameToolStripMenuItem.Enabled = false;
            }
        }

        private void StartGameEvent(object sender, EventArgs e)
        {
            var validateForm = new ValidateForm(this);
            if (validateForm.ShowDialog() == DialogResult.OK)
            {
                GameStart(new User(validateForm.infoTextBox.Text));
            }
        }

        private void UserAnswerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void AbortGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            GameStop();
            LoadGame();
            infoLabel.Text = "Игра была прервана. Ваше результат не учтён в общей статистике.";
        }

        private void AddQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addQuestionForm = new AddQuestionsForm(defaultFilePath);
            addQuestionForm.ShowDialog();
            LoadGame();
        }

        private void CreateNewStorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile.ShowDialog();
        }

        private void SaveFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FileProvider.CreateStorageFile(saveFile.FileName);
            var addQuestionForm = new AddQuestionsForm(saveFile.FileName);
            addQuestionForm.ShowDialog();
            LoadGame();
        }
    }
}
