using System;
using System.Drawing;
using System.Windows.Forms;

namespace Number_Guessing_Game_WinForms
{
    public partial class MainWindow : Form
    {
        private Random Random = new Random();
        private static class Properties
        {
            public static int lowerBound = 0;
            public static int upperBound = 1_000_000;
            public static int currentGuess = 0;
            public static bool isStarted = false;
            public static int triesLeft = 20;
            public static int roundsPlayed = 0;
            public static int wins = 0;
            public static int loses = 0;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        // Up and Down Buttons Handler
        private void upButton_Click(object sender, EventArgs e)
        {
            if (Properties.isStarted)
            {
                warningLabel.Visible = false;
                Properties.lowerBound = Properties.currentGuess + 1;
                Properties.triesLeft--;
                triesLeftLabel.Text = Properties.triesLeft.ToString();
                Guesser();
            }
            else
            {
                warningLabel.Visible = true;
            }
        }
        private void downButton_Click(object sender, EventArgs e)
        {
            if (Properties.isStarted)
            {
                warningLabel.Visible = false;
                Properties.upperBound = Properties.currentGuess - 1;
                Properties.triesLeft--;
                triesLeftLabel.Text = Properties.triesLeft.ToString();
                Guesser();
            }
            else
            {
                warningLabel.Visible = true;
            }
        }

        // Check Buttons Handler
        private void checkButton_Click(object sender, EventArgs e)
        {
            if (Properties.isStarted)
            {
                warningLabel.Visible = false;
                Properties.wins++;
                winsLabel.Text = Properties.wins.ToString();
                guessLabel.ForeColor = Color.Green;
                guessLabel.Text = Properties.currentGuess.ToString();
                MessageBox.Show("Hooraaayyy!!!\nI won the game!!!");
                ResetGame();
            }
            else
            {
                warningLabel.Visible = true;
            }
        }

        // Text Boxes Handler
        private void HandleBoundFieldChange(TextBox textBox, ref int boundValue)
        {
            if (textBox.Text == "")
            {
                textBox.Text = "0";
            }
            boundValue = Convert.ToInt32(textBox.Text);
        }

        private void lowerBoundField_TextChanged(object sender, EventArgs e)
        {
            HandleBoundFieldChange((TextBox)sender, ref Properties.lowerBound);
        }

        private void upperBoundField_TextChanged(object sender, EventArgs e)
        {
            HandleBoundFieldChange((TextBox)sender, ref Properties.upperBound);
        }

        private void boundField_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = 0.ToString();
        }

        private void boundField_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Name == upperBoundField.Name && Convert.ToInt32(upperBoundField.Text) < 10)
            {
                textBox.Text = 0.ToString();
                MessageBox.Show("Can't use Max less than 10!");
                textBox.Text = 10.ToString();
            }

            if (Convert.ToInt32(lowerBoundField.Text) > Convert.ToInt32(upperBoundField.Text))
            {
                MessageBox.Show("You can't choose a lower Max than Min.");
            }
        }

        // Start Button Handler
        private void startButton_Click(object sender, EventArgs e)
        {
            lowerBoundField.Enabled = false;
            upperBoundField.Enabled = false;
            Properties.isStarted = true;
            Guesser();
        }

        // Guesser Function
        private void Guesser()
        {
            // Warning when tries are low
            if (Properties.triesLeft < 10)
            {
                label2.ForeColor = Color.Yellow;
                triesLeftLabel.ForeColor = Color.Yellow;
            }
            if (Properties.triesLeft < 3)
            {
                label2.ForeColor = Color.Red;
                triesLeftLabel.ForeColor = Color.Red;
            }

            // Lose condition if tries run out
            if (Properties.triesLeft == 0)
            {
                Properties.loses++;
                losesLabel.Text = Properties.loses.ToString();
                MessageBox.Show("I've lost the game :(");
                ResetGame();
                return;  // Early return, no more guessing
            }

            // Checking where only one valid guess remains
            if (Properties.upperBound - Properties.lowerBound == 1)
            {
                Properties.currentGuess = Properties.lowerBound;
            }
            else if (Properties.upperBound - Properties.lowerBound == 2)
            {
                Properties.currentGuess = Properties.lowerBound + 1;
            }
            else if (Properties.upperBound - Properties.lowerBound > 2)
            {
                Properties.currentGuess = Random.Next(Properties.lowerBound, Properties.upperBound);
            }
            else
            {
                LoseHandler();
            }
            if (guessLabel.Visible == false)
            {
                guessLabel.Visible = true;
            }
            guessLabel.Text = $"Is it {Properties.currentGuess}?";
        }

        private void LoseHandler()
        {
            Properties.loses++;
            losesLabel.Text = Properties.wins.ToString();
            MessageBox.Show("I've lost the game :(");
            ResetGame();
        }

        private void ResetGame()
        {
            Properties.triesLeft = 20;
            triesLeftLabel.Text = Properties.triesLeft.ToString();
            triesLeftLabel.ForeColor = SystemColors.MenuHighlight;
            label2.ForeColor = SystemColors.MenuHighlight;
            guessLabel.ForeColor = Color.MediumOrchid;
            guessLabel.Visible = false;
            lowerBoundField.Enabled = true;
            upperBoundField.Enabled = true;
            Properties.isStarted = false;
            Properties.roundsPlayed++;
            roundsPlayedLabel.Text = Properties.roundsPlayed.ToString();
            Properties.currentGuess = 0;
            Properties.lowerBound = Convert.ToInt32(lowerBoundField.Text);
            Properties.upperBound = Convert.ToInt32(upperBoundField.Text);
        }

    }
}
