namespace TickTackToe
{
    partial class GameModeMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.userVSUserButton = new System.Windows.Forms.Button();
            this.userVSCPUButton = new System.Windows.Forms.Button();
            this.CPUVSCPUButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose your desired game mode.";
            // 
            // userVSUserButton
            // 
            this.userVSUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userVSUserButton.Location = new System.Drawing.Point(17, 122);
            this.userVSUserButton.Name = "userVSUserButton";
            this.userVSUserButton.Size = new System.Drawing.Size(122, 61);
            this.userVSUserButton.TabIndex = 1;
            this.userVSUserButton.Text = "User vs User";
            this.userVSUserButton.UseVisualStyleBackColor = true;
            this.userVSUserButton.Click += new System.EventHandler(this.userVSUserButton_Click);
            // 
            // userVSCPUButton
            // 
            this.userVSCPUButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userVSCPUButton.Location = new System.Drawing.Point(180, 122);
            this.userVSCPUButton.Name = "userVSCPUButton";
            this.userVSCPUButton.Size = new System.Drawing.Size(122, 61);
            this.userVSCPUButton.TabIndex = 2;
            this.userVSCPUButton.Text = "User vs CPU";
            this.userVSCPUButton.UseVisualStyleBackColor = true;
            this.userVSCPUButton.Click += new System.EventHandler(this.userVSCPUButton_Click);
            // 
            // CPUVSCPUButton
            // 
            this.CPUVSCPUButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUVSCPUButton.Location = new System.Drawing.Point(341, 122);
            this.CPUVSCPUButton.Name = "CPUVSCPUButton";
            this.CPUVSCPUButton.Size = new System.Drawing.Size(122, 61);
            this.CPUVSCPUButton.TabIndex = 3;
            this.CPUVSCPUButton.Text = "CPU vs CPU";
            this.CPUVSCPUButton.UseVisualStyleBackColor = true;
            this.CPUVSCPUButton.Click += new System.EventHandler(this.CPUVSCPUButton_Click);
            // 
            // GameModeMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(495, 210);
            this.Controls.Add(this.CPUVSCPUButton);
            this.Controls.Add(this.userVSCPUButton);
            this.Controls.Add(this.userVSUserButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(517, 266);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(517, 266);
            this.Name = "GameModeMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GameModeMessageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button userVSUserButton;
        private System.Windows.Forms.Button userVSCPUButton;
        private System.Windows.Forms.Button CPUVSCPUButton;
    }
}