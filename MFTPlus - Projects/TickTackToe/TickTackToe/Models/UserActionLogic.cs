using System.Drawing;
using System.Windows.Forms;

namespace TickTackToe.Models
{
    internal class UserActionLogic
    {
        // Handling user turn
        public static void run(Button button, string currentPlayer)
        {
            // Making changes on the selected button
            button.Enabled = false;
            button.Text = GameStats.currentPlayer;
            button.BackColor = Color.Aqua;

            // Removing the button from the buttons list in order to make it unavailable
            GameStats.buttons.Remove(button);
        }
    }
}
