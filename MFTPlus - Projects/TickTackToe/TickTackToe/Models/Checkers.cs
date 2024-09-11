using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static TickTackToe.Models.GameStats;


namespace TickTackToe.Models
{
    internal class Checkers
    {

        // Checking if there is any winner
        public static bool checkWinner(List<Button> buttonsList, Label userWinCount, Label cpuWinCount, Label uiCounter, string symbol)
        {
            // Handling the win condition
            if (buttonsList[0].Text == symbol && buttonsList[1].Text == symbol && buttonsList[2].Text == symbol
                || buttonsList[3].Text == symbol && buttonsList[4].Text == symbol && buttonsList[5].Text == symbol
                || buttonsList[6].Text == symbol && buttonsList[7].Text == symbol && buttonsList[8].Text == symbol
                || buttonsList[0].Text == symbol && buttonsList[4].Text == symbol && buttonsList[8].Text == symbol
                || buttonsList[2].Text == symbol && buttonsList[4].Text == symbol && buttonsList[6].Text == symbol
                || buttonsList[0].Text == symbol && buttonsList[3].Text == symbol && buttonsList[6].Text == symbol
                || buttonsList[1].Text == symbol && buttonsList[4].Text == symbol && buttonsList[7].Text == symbol
                || buttonsList[2].Text == symbol && buttonsList[5].Text == symbol && buttonsList[8].Text == symbol)
            {
                // Incrementing the rounds count and updating the UI
                rounds++;
                uiCounter.Text = Convert.ToString(rounds);

                // Handling the user win condition
                if (symbol == PlayerSymbol)
                {
                    userWins++;
                    userWinCount.Text = Convert.ToString(userWins);
                    MessageBox.Show("User Wins!");
                }
                // Handling the CPU win condition
                if (symbol == OpponentSymbol)
                {
                    cpuWins++;
                    cpuWinCount.Text = Convert.ToString(cpuWins);
                    MessageBox.Show("AI Wins!");
                }

                // Resetting the board
                ResetBoard.reset(buttonsList);
                return true;
            }
            return false;
        }


        // Checking if the game is draw
        public static bool checkDraw(Label uiCounter, List<Button> buttonsList)
        {
            // Returning false if the game still can continue
            if (GameStats.buttons.Count > 0) { return false; }

            // Handling game draw logic
            else
            {
                // Incrementing the rounds count and update the UI
                rounds++;
                uiCounter.Text = Convert.ToString(rounds);

                // Showing a message and resetting the board
                MessageBox.Show("Tie!");
                ResetBoard.reset(buttonsList);
                return true;
            }
        }
    }
}
