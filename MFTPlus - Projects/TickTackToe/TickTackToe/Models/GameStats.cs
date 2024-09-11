using System.Collections.Generic;
using System.Windows.Forms;

namespace TickTackToe.Models
{
    internal class GameStats
    {
        // Making available game modes
        public enum GameMode
        {
            UserVsUser = 1,
            UserVsCpu = 2,
            CpuVsCpu = 3
        }
        public static GameMode SelectedGameMode { get; set; }

        // Setting the user chosen game mode
        public static int gameMode;
        public static bool modeChanged = false;

        // Defining the player's symbols
        public const string PlayerSymbol = "X";
        public const string OpponentSymbol = "O";
        public static string currentPlayer = PlayerSymbol;

        public static void ChangeTurn()
        {
            if (currentPlayer == PlayerSymbol)
            {
                currentPlayer = OpponentSymbol;
            }
            else
            {
                currentPlayer = PlayerSymbol;
            }
        }

        // Defining the buttons list variable
        public static List<Button> buttons;

        // Saving game specific stats
        public static int userWins = 0;
        public static int cpuWins = 0;
        public static int rounds = 0;

        // Creator's information
        public static string creator = "Amirhossein Gholizadeh";
        public static string creatorGmail = "Amirhosseingholizadeh1998@gmail.com";
        public static string creatorGithub = "Amirhossein77-98";
        public static string dotNetVersion = "8.0";
    }
}
