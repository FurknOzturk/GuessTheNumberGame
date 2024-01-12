namespace GuessTheNumberGame
{
    public partial class GuessTheNumberForm : Form
    {
        public GuessTheNumberForm()
        {
            InitializeComponent();
            this.AcceptButton = EnterTheGuessButton;
        }

        int computersRandom;

        private void GuessTheNumberForm_Load(object sender, EventArgs e)
        {
            EnterTheGuessButton.Enabled = false;
            progressBar1.Maximum = 60;
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            StartGameButton.Enabled = false;
            EnterTheGuessButton.Enabled = true;
            progressBar1.Value = progressBar1.Maximum;
            timer1.Start();

            Random random = new Random();
            computersRandom = random.Next(1, 101);
        }

        private void EnterTheGuessButton_Click(object sender, EventArgs e)
        {
            int value = 0;

            try
            {
                if (String.IsNullOrEmpty(GuessTextBox.Text))
                {
                    throw new ArgumentException("Your entry cannot be empty. You must enter a number");
                }
                if (!int.TryParse(GuessTextBox.Text, out value))
                {
                    throw new FormatException("Your entry is in the wrong format! You can only use numbers.");
                }
                if (value > 100 || value < 1)
                {
                    throw new Exception("Your entry is out of bounds. You must enter a number from 1 to 100");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (value > computersRandom)
            {
                InformationLabel.Text = "Guess a smaller number";
            }
            else if (value < computersRandom)
            {
                InformationLabel.Text = "Guess a bigger number";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show($"Congratulations! You guessed the number correctly in {60 - progressBar1.Value} seconds!");
                Application.Exit();
            }
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            EnterTheGuessButton.Text = $"Enter the Guess ({progressBar1.Value})";

            switch (progressBar1.Value)
            {
                case 60:
                    timerLabel.Text = "Time has started. Good Luck!";
                    break;
                case 30:
                    timerLabel.Text = "Last 30 seconds!";
                    break;
                case 10:
                    timerLabel.Text = "Last 10 seconds!";
                    break;
                case 5:
                    timerLabel.Text = "Last 5 seconds!";
                    break;
                case 0:
                    timer1.Stop();
                    MessageBox.Show("Game Over. You couldn't guess the number correctly within the given 60 seconds!");
                    Application.Exit();
                    break;
            }
            if (progressBar1.Value > 0)
            {
                progressBar1.Value--;
            }
        }
    }
}