namespace Number_Guessing_Game
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.winsLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RoundsLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LosesLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(263, 236);
            this.textBox1.MaxLength = 1;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 60);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.WordWrap = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(402, 236);
            this.textBox2.MaxLength = 1;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 60);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.WordWrap = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(536, 236);
            this.textBox3.MaxLength = 1;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 60);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.WordWrap = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(669, 236);
            this.textBox4.MaxLength = 1;
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 60);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu Mono", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number Guessing Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(451, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Left Tries:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(554, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "5";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(452, 383);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(130, 48);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // winsLabel
            // 
            this.winsLabel.AutoSize = true;
            this.winsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winsLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.winsLabel.Location = new System.Drawing.Point(323, 135);
            this.winsLabel.Name = "winsLabel";
            this.winsLabel.Size = new System.Drawing.Size(24, 26);
            this.winsLabel.TabIndex = 9;
            this.winsLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(256, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Wins:";
            // 
            // RoundsLabel
            // 
            this.RoundsLabel.AutoSize = true;
            this.RoundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundsLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RoundsLabel.Location = new System.Drawing.Point(594, 135);
            this.RoundsLabel.Name = "RoundsLabel";
            this.RoundsLabel.Size = new System.Drawing.Size(24, 26);
            this.RoundsLabel.TabIndex = 11;
            this.RoundsLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(434, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "Rounds Played:";
            // 
            // LosesLabel
            // 
            this.LosesLabel.AutoSize = true;
            this.LosesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LosesLabel.ForeColor = System.Drawing.Color.Crimson;
            this.LosesLabel.Location = new System.Drawing.Point(749, 135);
            this.LosesLabel.Name = "LosesLabel";
            this.LosesLabel.Size = new System.Drawing.Size(24, 26);
            this.LosesLabel.TabIndex = 13;
            this.LosesLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(676, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 26);
            this.label9.TabIndex = 12;
            this.label9.Text = "Loses:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1044, 495);
            this.Controls.Add(this.LosesLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RoundsLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.winsLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label winsLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label RoundsLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LosesLabel;
        private System.Windows.Forms.Label label9;
    }
}

