using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using TickTackToe.Models;
using static TickTackToe.Models.Checkers;
using static TickTackToe.Models.GameStats;


namespace TickTackToe
{
    public partial class TicTacToe : Form
    {

        // Initialize Game
        public TicTacToe()
        {
            InitializeComponent();

            // Initializing the buttons list
            buttons = getButtonsList();

            // Asking the user to choose the game mode
            GameModeMessageBox.GameModeSelectionWindow();
        }


        // Handle User Clicks
        public void player_click(object sender, EventArgs e)
        {

            if (gameMode != Convert.ToInt32(GameMode.CpuVsCpu))
            {
                // Getting the clicked button and running the user clicked logic to make changes on the button
                Button button = (Button)sender;
                UserActionLogic.run(button, currentPlayer);


                // Checking if there is a winner or the game is draw, if yes, skip CPU's turn
                if (checkWinner(getButtonsList(), userWinCount, cpuWinCount, roundsCount, currentPlayer)) { return; }
                if (checkDraw(roundsCount, getButtonsList())) { return; }

                // Change the current user
                ChangeTurn();
            }


            // Run if CPU should play
            if (gameMode != Convert.ToInt32(GameMode.UserVsUser))
            {
                // Calling the CPU turn
                opponent_Click();
            }
        }


        // Handle CPU Clicks
        private async void opponent_Click()
        {
            // Skipping the CPU turn if all the buttons are selected
            if (buttons.Count <= 0) { return; }

            Button isWinning = winPossibilityCheck(getButtonsList());
            // Running the corresponding Logic
            if (gameMode == Convert.ToInt32(GameMode.UserVsCpu)) { await CPUActionLogic.run(currentPlayer, isWinning); }
            if (gameMode == Convert.ToInt32(GameMode.CpuVsCpu)) { await CPUActionLogic.run(currentPlayer, isWinning); }


            // Checking if there is a winner or the game is draw
            if (checkWinner(getButtonsList(), userWinCount, cpuWinCount, roundsCount, currentPlayer)) { return; }
            if (checkDraw(roundsCount, getButtonsList())) { return; }

            ChangeTurn();
        }


        // Handling Reset Button Click
        private void reset_button_Click(object sender, EventArgs e)
        {
            // Resetting the board
            ResetBoard.reset(getButtonsList());

            // Resetting the game stats
            userWins = 0;
            cpuWins = 0;
            rounds = 0;

            // Resetting the ui counters
            roundsCount.Text = Convert.ToString(rounds);
            userWinCount.Text = Convert.ToString(userWins);
            cpuWinCount.Text = Convert.ToString(cpuWins);
        }


        // Handling About Dialog Button Clicked
        private void showAboutDialog(object sender, EventArgs e)
        {
            string about = $"Credits:\n\nCreator: {creator}\nGmail: {creatorGmail}\nGithub: {creatorGithub}\n.Net Version: {dotNetVersion}";
            MessageBox.Show(about);
        }

        // Fetching and returning Game Buttons
        public List<Button> getButtonsList()
        {
            return new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        }

        private void GameModeButton_Clicked(object sender, EventArgs e)
        {
            GameModeMessageBox.GameModeSelectionWindow();
        }

        private void TicTacToe_Activated(object sender, EventArgs e)
        {
            if (modeChanged)
            {
                // Resetting the board
                ResetBoard.reset(getButtonsList());

                // Resetting the game stats
                userWins = 0;
                cpuWins = 0;
                rounds = 0;

                // Resetting the ui counters
                roundsCount.Text = Convert.ToString(rounds);
                userWinCount.Text = Convert.ToString(userWins);
                cpuWinCount.Text = Convert.ToString(cpuWins);
                modeChanged = false;
            }
        }

        private async Task autoClicker()
        {
            while (true)
            {
                foreach (Button button in buttons)
                {
                    button.PerformClick();
                }
                await Task.Delay(1000);
            }
        }

        private async void TicTacToe_Shown(object sender, EventArgs e)
        {
            if (gameMode == Convert.ToInt32(GameMode.CpuVsCpu)) autoClicker();
        }
    }
}
