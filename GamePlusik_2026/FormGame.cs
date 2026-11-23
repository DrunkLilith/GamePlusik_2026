namespace GamePlusik_2026
{
    public partial class FormGame : Form
    {
        int TargetNum = 21;
        int UserNum = 1;
        int CountStep = 0;
        Random rnd = new Random();

        public FormGame()
        {
            InitializeComponent();
            labelTarget.Text = TargetNum.ToString();
        }

        int Optimum(int k)
        {
            int steps = 0;
            while (k != 1)
            {
                if (k % 2 == 0)
                {
                    k = k / 2;
                }
                else
                {
                    k = k - 1;
                }
                steps++;
            }
            return steps;
        }

        void UpdateLabels()
        {
            labelUserNumber.Text = UserNum.ToString();
            labelCountStep.Text = "Количество шагов: " + CountStep;
        }

        void ResetGame()
        {
            UserNum = 1;
            CountStep = 0;
            UpdateLabels();
        }

        void CheckResult()
        {
            if (UserNum == TargetNum)
            {
                int optimum = Optimum(TargetNum);
                if (CountStep == optimum)
                    MessageBox.Show("Выиграл за оптимальное число шагов!");
                else
                    MessageBox.Show("Выиграл, но можно за меньшее число шагов!\nОптимальное число шагов: " + optimum);
                ResetGame();
            }
            else if (UserNum > TargetNum)
            {
                MessageBox.Show("Проиграл!");
                ResetGame();
            }
        }

        private void pictureBoxPlus_Click(object sender, EventArgs e)
        {
            //UserNum = UserNum + 1;
            UserNum++;
            CountStep++;
            UpdateLabels();
            CheckResult();
        }

        private void pictureBoxMult_Click(object sender, EventArgs e)
        {
            //UserNum = UserNum * 2;
            UserNum *= 2;
            CountStep++;
            UpdateLabels();
            CheckResult();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            TargetNum = rnd.Next(10, 101);
            labelTarget.Text = TargetNum.ToString();
            ResetGame();
        }
    }
}
