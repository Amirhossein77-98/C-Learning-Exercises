using System;
using System.Windows.Forms;
using TickTackToe.Models;
using static TickTackToe.Models.GameStats;

namespace TickTackToe
{
    // Generating a window to ask the user to select a game mode
    public partial class GameModeMessageBox : Form
    {
        // Flag to check if the user selected a game mode
        private bool gameModeSelected = false;

        // Initializing the window
        public GameModeMessageBox()
        {
            InitializeComponent();
            // Subscribing to the FormClosing event
            this.FormClosing += GameModeMessageBox_FormClosing;
        }

        // Handling user vs user choice
        private void userVSUserButton_Click(object sender, EventArgs e)
        {
            gameModeSelected = true;
            DialogResult = DialogResult.OK;
            gameMode = Convert.ToInt32(GameMode.UserVsUser);
            modeChanged = true;
        }

        // Handling user vs CPU choice
        private void userVSCPUButton_Click(object sender, EventArgs e)
        {
            gameModeSelected = true;
            DialogResult = DialogResult.OK;
            gameMode = Convert.ToInt32(GameMode.UserVsCpu);
            modeChanged = true;
        }

        // Handling CPU vs CPU choice
        private void CPUVSCPUButton_Click(object sender, EventArgs e)
        {
            gameModeSelected = true;
            DialogResult = DialogResult.OK;
            gameMode = Convert.ToInt32(GameMode.CpuVsCpu);
            modeChanged = true;
        }

        // Handling the form closing event to terminate the application if no game mode is selected
        private void GameModeMessageBox_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (gameMode == 1 || gameMode == 2 || gameMode == 3)
            {
                gameModeSelected = true;
            }
            // If no game mode is selected and the user closes the window
            if (!gameModeSelected)
            {
                Application.Exit();
            }
        }

        // Running and setting the user's choice as the game mode
        public static void GameModeSelectionWindow()
        {
            GameModeMessageBox gameModeSelection = new GameModeMessageBox();
            DialogResult gameModeSelectorWindowResult = gameModeSelection.ShowDialog();
            if (gameModeSelectorWindowResult == DialogResult.OK)
            {
                if (gameModeSelection.Tag is int selectedGameMode)
                {
                    gameMode = selectedGameMode;
                }
            }
        }
    }
}
