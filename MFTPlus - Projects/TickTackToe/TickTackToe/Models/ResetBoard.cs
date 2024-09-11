using System.Collections.Generic;
using System.Windows.Forms;

namespace TickTackToe.Models
{
    internal class ResetBoard
    {
        // Handling the board reset logic
        public static void reset(List<Button> buttons)
        {
            // Resetting buttons list to make them all available again
            GameStats.buttons = buttons;
            foreach (Button button in GameStats.buttons)
            {
                button.Text = "";
                button.Enabled = true;
                button.BackColor = System.Drawing.SystemColors.Control;
                GameStats.currentPlayer = GameStats.PlayerSymbol;
            }
        }
    }
}
