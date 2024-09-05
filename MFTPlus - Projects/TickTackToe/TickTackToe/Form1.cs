using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickTackToe
{
    public partial class TicTacToe : Form
    {
        private const string PlayerSymbol = "X";
        private const string AiSymbol = "O";
        private List<Button> buttons;
        private Random random = new Random();
        private int userWins = 0;
        private int cpuWins = 0;
        private int rounds = 0;

        public TicTacToe()
        {
            InitializeComponent();
            load_Buttons();
        }

        private void load_Buttons()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6,
                button7, button8, button9 };
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Enabled = false;
            button.Text = PlayerSymbol;
            button.BackColor = Color.Aqua;
            buttons.Remove(button);
            if (checkWinner())
            {
                userWins++;
                userWinCount.Text = Convert.ToString(userWins);
                MessageBox.Show("User Wins!");
                resetGame();
                return;
            }
            if (checkDraw())
            {
                return;
            }
            cpu_Click();
        }

        private void cpu_Click()
        {
            if (buttons.Count > 0)
            {
                foreach (Button button in buttons)
                {
                    button.Enabled = false;
                }
                int buttonIndex = random.Next(buttons.Count);
                buttons[buttonIndex].Enabled = false;
                buttons[buttonIndex].Text = AiSymbol;
                buttons[buttonIndex].BackColor = Color.Beige;
                buttons.Remove(buttons[buttonIndex]);
                foreach (Button button in buttons)
                {
                    button.Enabled = true;
                }
                if (checkWinner())
                {
                    cpuWins++;
                    cpuWinCount.Text = Convert.ToString(cpuWins);
                    MessageBox.Show("AI Wins!");
                    resetGame();
                }
            }
            checkDraw();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            resetGame();
            userWins = 0;
            cpuWins = 0;
            rounds = 0;
            roundsCount.Text = Convert.ToString(rounds);
            userWinCount.Text = Convert.ToString(userWins);
            cpuWinCount.Text = Convert.ToString(cpuWins);
        }

        private void resetGame()
        {
            load_Buttons();
            foreach (Button button in buttons)
            {
                button.Text = "";
                button.Enabled = true;
                button.BackColor = DefaultBackColor;
            }
        }

        private bool checkWinner()
        {
            return checkLines(PlayerSymbol) || checkLines(AiSymbol);
        }

        private bool checkLines(string symbol)
        {
            if (button1.Text == symbol && button2.Text == symbol && button3.Text == symbol
                || button4.Text == symbol && button5.Text == symbol && button6.Text == symbol
                || button7.Text == symbol && button8.Text == symbol && button9.Text == symbol
                || button1.Text == symbol && button5.Text == symbol && button9.Text == symbol
                || button3.Text == symbol && button5.Text == symbol && button7.Text == symbol
                || button1.Text == symbol && button4.Text == symbol && button7.Text == symbol
                || button2.Text == symbol && button5.Text == symbol && button8.Text == symbol
                || button3.Text == symbol && button6.Text == symbol && button9.Text == symbol)
            {
                roundCounter();
                return true;
            }
            return false;
        }

        private bool checkDraw()
        {
            if (buttons.Count > 0)
            {
                return false;
            }
            else
            {
                MessageBox.Show("Tie!");
                roundCounter();
                resetGame();
                return true;
            }
        }

        private void roundCounter()
        {
            rounds++;
            roundsCount.Text = Convert.ToString(rounds);
        }

        private void showAboutDialog(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string about = @"
Credits:

Creator: Amirhossein Gholizadeh
Gmail: Amirhosseingholizadeh1998@gmail.com
Github: Amirhossein77-98
.Net Version: 8.0
";
            MessageBox.Show(about);
        }
    }
}
