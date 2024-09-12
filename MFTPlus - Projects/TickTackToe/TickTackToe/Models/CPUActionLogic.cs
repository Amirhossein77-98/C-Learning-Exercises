using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickTackToe.Models
{
    internal class CPUActionLogic
    {
        // Handling CPU turn
        public async static Task run(string currentPlayer, Button potentialButtonToWin)
        {

            // Blocking buttons to avoid user clicks
            foreach (Button button in GameStats.buttons)
            {
                button.Enabled = false;
            }

            // Adding delay to make it more natural
            await Task.Delay(500);

            // Selecting the button that has the potential for the user to win, if it is not selected already
            if (potentialButtonToWin != null && potentialButtonToWin.Text == "")
            {
                // Making changes on the chosen button
                potentialButtonToWin.Enabled = false;
                potentialButtonToWin.Text = currentPlayer;
                potentialButtonToWin.BackColor = Color.Beige;

                // Removing the button from the buttons list in order to make it unavailable
                GameStats.buttons.Remove(potentialButtonToWin);
            }

            // Selecting a random button if there is no potentiality for the user to win
            else
            {
                // Choosing a button and signing it
                Random random = new Random();
                int buttonIndex = random.Next(GameStats.buttons.Count);

                // Making changes on the chosen button
                GameStats.buttons[buttonIndex].Enabled = false;
                GameStats.buttons[buttonIndex].Text = currentPlayer;
                GameStats.buttons[buttonIndex].BackColor = Color.Beige;

                // Removing the button from the buttons list in order to make it unavailable
                GameStats.buttons.Remove(GameStats.buttons[buttonIndex]);
            }


            // Enabling the remaining buttons again
            foreach (Button button in GameStats.buttons)
            {
                button.Enabled = true;
            }
        }
    }
}
