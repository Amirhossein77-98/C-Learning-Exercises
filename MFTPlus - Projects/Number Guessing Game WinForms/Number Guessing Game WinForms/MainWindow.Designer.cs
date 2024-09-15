namespace Number_Guessing_Game_WinForms
{
    partial class MainWindow
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
            this.upButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.appTitleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.triesLeftLabel = new System.Windows.Forms.Label();
            this.guessLabel = new System.Windows.Forms.Label();
            this.lowerBoundField = new System.Windows.Forms.TextBox();
            this.upperBoundField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.roundsPlayedLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.winsLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.losesLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // upButton
            // 
            this.upButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upButton.ForeColor = System.Drawing.Color.Firebrick;
            this.upButton.Location = new System.Drawing.Point(135, 461);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(128, 65);
            this.upButton.TabIndex = 0;
            this.upButton.Text = "⬆️";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.checkButton.Location = new System.Drawing.Point(330, 461);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(128, 65);
            this.checkButton.TabIndex = 1;
            this.checkButton.Text = "✔️";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // downButton
            // 
            this.downButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downButton.ForeColor = System.Drawing.Color.Firebrick;
            this.downButton.Location = new System.Drawing.Point(508, 461);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(128, 65);
            this.downButton.TabIndex = 2;
            this.downButton.Text = "⬇️";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // appTitleLabel
            // 
            this.appTitleLabel.AutoSize = true;
            this.appTitleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.appTitleLabel.Location = new System.Drawing.Point(155, 9);
            this.appTitleLabel.Name = "appTitleLabel";
            this.appTitleLabel.Size = new System.Drawing.Size(462, 47);
            this.appTitleLabel.TabIndex = 3;
            this.appTitleLabel.Text = "Number Guessing Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(253, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of tries left:";
            // 
            // triesLeftLabel
            // 
            this.triesLeftLabel.AutoSize = true;
            this.triesLeftLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triesLeftLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.triesLeftLabel.Location = new System.Drawing.Point(485, 65);
            this.triesLeftLabel.Name = "triesLeftLabel";
            this.triesLeftLabel.Size = new System.Drawing.Size(39, 30);
            this.triesLeftLabel.TabIndex = 5;
            this.triesLeftLabel.Text = "20";
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessLabel.ForeColor = System.Drawing.Color.MediumOrchid;
            this.guessLabel.Location = new System.Drawing.Point(325, 330);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(51, 37);
            this.guessLabel.TabIndex = 7;
            this.guessLabel.Text = "20";
            this.guessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.guessLabel.Visible = false;
            // 
            // lowerBoundField
            // 
            this.lowerBoundField.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lowerBoundField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lowerBoundField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerBoundField.Location = new System.Drawing.Point(309, 249);
            this.lowerBoundField.MaxLength = 1000000;
            this.lowerBoundField.Multiline = true;
            this.lowerBoundField.Name = "lowerBoundField";
            this.lowerBoundField.Size = new System.Drawing.Size(100, 30);
            this.lowerBoundField.TabIndex = 8;
            this.lowerBoundField.Text = "0";
            this.lowerBoundField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lowerBoundField.TextChanged += new System.EventHandler(this.lowerBoundField_TextChanged);
            this.lowerBoundField.Enter += new System.EventHandler(this.boundField_Enter);
            this.lowerBoundField.Leave += new System.EventHandler(this.boundField_Leave);
            // 
            // upperBoundField
            // 
            this.upperBoundField.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.upperBoundField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.upperBoundField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperBoundField.Location = new System.Drawing.Point(450, 249);
            this.upperBoundField.MaxLength = 10000000;
            this.upperBoundField.Multiline = true;
            this.upperBoundField.Name = "upperBoundField";
            this.upperBoundField.Size = new System.Drawing.Size(100, 30);
            this.upperBoundField.TabIndex = 9;
            this.upperBoundField.Text = "10000000";
            this.upperBoundField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.upperBoundField.WordWrap = false;
            this.upperBoundField.TextChanged += new System.EventHandler(this.upperBoundField_TextChanged);
            this.upperBoundField.Enter += new System.EventHandler(this.boundField_Enter);
            this.upperBoundField.Leave += new System.EventHandler(this.boundField_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(421, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(107, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Min-max boundaries:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(577, 247);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(59, 34);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // roundsPlayedLabel
            // 
            this.roundsPlayedLabel.AutoSize = true;
            this.roundsPlayedLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundsPlayedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.roundsPlayedLabel.Location = new System.Drawing.Point(452, 105);
            this.roundsPlayedLabel.Name = "roundsPlayedLabel";
            this.roundsPlayedLabel.Size = new System.Drawing.Size(26, 30);
            this.roundsPlayedLabel.TabIndex = 14;
            this.roundsPlayedLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(284, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rounds Played:";
            // 
            // winsLabel
            // 
            this.winsLabel.AutoSize = true;
            this.winsLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winsLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.winsLabel.Location = new System.Drawing.Point(398, 146);
            this.winsLabel.Name = "winsLabel";
            this.winsLabel.Size = new System.Drawing.Size(26, 30);
            this.winsLabel.TabIndex = 16;
            this.winsLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LimeGreen;
            this.label6.Location = new System.Drawing.Point(334, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 30);
            this.label6.TabIndex = 15;
            this.label6.Text = "Wins:";
            // 
            // losesLabel
            // 
            this.losesLabel.AutoSize = true;
            this.losesLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.losesLabel.ForeColor = System.Drawing.Color.Crimson;
            this.losesLabel.Location = new System.Drawing.Point(398, 185);
            this.losesLabel.Name = "losesLabel";
            this.losesLabel.Size = new System.Drawing.Size(26, 30);
            this.losesLabel.TabIndex = 18;
            this.losesLabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(329, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 30);
            this.label8.TabIndex = 17;
            this.label8.Text = "Loses:";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(214, 568);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(347, 31);
            this.warningLabel.TabIndex = 19;
            this.warningLabel.Text = "Please Start the Game First!";
            this.warningLabel.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(778, 638);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.losesLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.winsLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.roundsPlayedLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upperBoundField);
            this.Controls.Add(this.lowerBoundField);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.triesLeftLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.appTitleLabel);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(800, 694);
            this.MinimumSize = new System.Drawing.Size(800, 694);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Label appTitleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label triesLeftLabel;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.TextBox lowerBoundField;
        private System.Windows.Forms.TextBox upperBoundField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label roundsPlayedLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label winsLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label losesLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label warningLabel;
    }
}

