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
                    if (gameMode != Convert.ToInt32(GameMode.CpuVsCpu)) MessageBox.Show("Player 1 Wins!");
                }
                // Handling the CPU win condition
                if (symbol == OpponentSymbol)
                {
                    cpuWins++;
                    cpuWinCount.Text = Convert.ToString(cpuWins);
                    if (gameMode != Convert.ToInt32(GameMode.CpuVsCpu)) MessageBox.Show("Player 2 Wins!");
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
                if (gameMode != Convert.ToInt32(GameMode.CpuVsCpu)) MessageBox.Show("Tie!");
                ResetBoard.reset(buttonsList);
                return true;
            }
            return false;
        }

        public static Button winPossibilityCheck(List<Button> buttonsList)
        {
            // Check win possibility for every button
            for (int i = 0; i < 9; i++)
            {
                // Check win possibility horizontally
                if (i < 8)
                {
                    // Check the buttons two by two except for the last column
                    if (buttonsList[i].Text == PlayerSymbol && buttonsList[i + 1].Text == PlayerSymbol && i != 2 && i != 5)
                    {
                        // If first two buttons are the same
                        if (i == 0 || i == 3 || i == 6 && buttonsList[i + 2].Text == "")
                        {
                            // Return the third button of the row
                            return buttonsList[i + 2];
                        }
                        // If second two buttons are the same
                        if (i == 1 || i == 4 || i == 7 && buttonsList[i - 1].Text == "")
                        {
                            // Return the first button of the row
                            return buttonsList[i - 1];
                        }
                    }
                }

                // Check win possibility vertically
                if (i < 6)
                {
                    // Check if each button and the button under it are the chosen by the same user
                    if (buttonsList[i].Text == PlayerSymbol && buttonsList[i + 3].Text == PlayerSymbol)
                    {
                        // Check the first row and their below button
                        if (i == 0 || i == 1 || i == 2 && buttonsList[i + 6].Text == "")
                        {
                            // Return the last button in the column to select
                            return buttonsList[i + 6];
                        }
                        // Check the second row and their below button
                        if (i == 3 || i == 4 || i == 5 && buttonsList[i - 3].Text == "")
                        {
                            // Return the first button in the column to select
                            return buttonsList[i - 3];
                        }
                    }
                }

                // Check win possibility diagonally
                if (i == 0 || i == 2 || i == 6 || i == 8)
                {
                    // Check if each corner button and the middle button are the same
                    if (buttonsList[i].Text == PlayerSymbol && buttonsList[4].Text == PlayerSymbol)
                    {
                        // Return the last button in the diagonal direction if the first button and the middle button are the same
                        if (i == 0 && buttonsList[i + 8].Text == "")
                        {
                            return buttonsList[i + 8];
                        }
                        // Return the last button in the diagonal direction if the third button and the middle button are the same
                        if (i == 2 && buttonsList[i + 4].Text == "")
                        {
                            return buttonsList[i + 4];
                        }
                        // Return the third button in the diagonal direction if the seventh button and the middle button are the same
                        if (i == 6 && buttonsList[i - 4].Text == "")
                        {
                            return buttonsList[i - 4];
                        }
                        // Return the first button in the diagonal direction if the ninth button and the middle button are the same
                        if (i == 8 && buttonsList[i - 8].Text == "")
                        {
                            return buttonsList[i - 8];
                        }
                    }
                }
            }
            // Return null if there is no win possibility
            return null;
        }
    }
}
