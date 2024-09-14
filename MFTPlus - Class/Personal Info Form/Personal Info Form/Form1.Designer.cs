namespace Personal_Info_Form
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
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.educationLabel = new System.Windows.Forms.Label();
            this.firstnameField = new System.Windows.Forms.TextBox();
            this.lastnameField = new System.Windows.Forms.TextBox();
            this.phoneNumberField = new System.Windows.Forms.TextBox();
            this.emailField = new System.Windows.Forms.TextBox();
            this.addressField = new System.Windows.Forms.TextBox();
            this.educationComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.firstnameFieldWarn = new System.Windows.Forms.Label();
            this.lastnameFieldWarn = new System.Windows.Forms.Label();
            this.phoneNumberFieldWarn = new System.Windows.Forms.Label();
            this.emailFieldWarn = new System.Windows.Forms.Label();
            this.educationComboBoxWarn = new System.Windows.Forms.Label();
            this.addressFieldWarn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Font = new System.Drawing.Font("Neirizi", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.firstnameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstnameLabel.Location = new System.Drawing.Point(29, 140);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(151, 60);
            this.firstnameLabel.TabIndex = 0;
            this.firstnameLabel.Text = "Firstname:";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Font = new System.Drawing.Font("Neirizi", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lastnameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastnameLabel.Location = new System.Drawing.Point(29, 204);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(146, 60);
            this.lastnameLabel.TabIndex = 1;
            this.lastnameLabel.Text = "Lastname:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Neirizi", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.phoneNumberLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.phoneNumberLabel.Location = new System.Drawing.Point(29, 269);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(105, 60);
            this.phoneNumberLabel.TabIndex = 2;
            this.phoneNumberLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Neirizi", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailLabel.Location = new System.Drawing.Point(29, 334);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(109, 60);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "E-mail:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Neirizi", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.addressLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addressLabel.Location = new System.Drawing.Point(29, 441);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(127, 60);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address:";
            // 
            // educationLabel
            // 
            this.educationLabel.AutoSize = true;
            this.educationLabel.Font = new System.Drawing.Font("Neirizi", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.educationLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.educationLabel.Location = new System.Drawing.Point(29, 388);
            this.educationLabel.Name = "educationLabel";
            this.educationLabel.Size = new System.Drawing.Size(149, 60);
            this.educationLabel.TabIndex = 5;
            this.educationLabel.Text = "Education:";
            // 
            // firstnameField
            // 
            this.firstnameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstnameField.Location = new System.Drawing.Point(184, 142);
            this.firstnameField.Multiline = true;
            this.firstnameField.Name = "firstnameField";
            this.firstnameField.Size = new System.Drawing.Size(478, 46);
            this.firstnameField.TabIndex = 6;
            this.firstnameField.TextChanged += new System.EventHandler(this.addressField_TextChanged);
            this.firstnameField.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // lastnameField
            // 
            this.lastnameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastnameField.Location = new System.Drawing.Point(184, 204);
            this.lastnameField.Multiline = true;
            this.lastnameField.Name = "lastnameField";
            this.lastnameField.Size = new System.Drawing.Size(478, 46);
            this.lastnameField.TabIndex = 7;
            this.lastnameField.TextChanged += new System.EventHandler(this.addressField_TextChanged);
            this.lastnameField.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // phoneNumberField
            // 
            this.phoneNumberField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumberField.Location = new System.Drawing.Point(184, 269);
            this.phoneNumberField.Multiline = true;
            this.phoneNumberField.Name = "phoneNumberField";
            this.phoneNumberField.Size = new System.Drawing.Size(478, 46);
            this.phoneNumberField.TabIndex = 8;
            this.phoneNumberField.TextChanged += new System.EventHandler(this.addressField_TextChanged);
            this.phoneNumberField.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // emailField
            // 
            this.emailField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailField.Location = new System.Drawing.Point(184, 334);
            this.emailField.Multiline = true;
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(478, 46);
            this.emailField.TabIndex = 9;
            this.emailField.TextChanged += new System.EventHandler(this.addressField_TextChanged);
            this.emailField.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // addressField
            // 
            this.addressField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressField.Location = new System.Drawing.Point(184, 454);
            this.addressField.Multiline = true;
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(478, 213);
            this.addressField.TabIndex = 10;
            this.addressField.TextChanged += new System.EventHandler(this.addressField_TextChanged);
            this.addressField.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // educationComboBox
            // 
            this.educationComboBox.FormattingEnabled = true;
            this.educationComboBox.Items.AddRange(new object[] {
            "BA",
            "Masters",
            "PhD"});
            this.educationComboBox.Location = new System.Drawing.Point(184, 399);
            this.educationComboBox.Name = "educationComboBox";
            this.educationComboBox.Size = new System.Drawing.Size(108, 28);
            this.educationComboBox.TabIndex = 11;
            this.educationComboBox.TextChanged += new System.EventHandler(this.addressField_TextChanged);
            this.educationComboBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRJadid", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 71);
            this.label1.TabIndex = 12;
            this.label1.Text = "Personal Data Form";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(311, 722);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(203, 73);
            this.submitButton.TabIndex = 13;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // firstnameFieldWarn
            // 
            this.firstnameFieldWarn.AutoSize = true;
            this.firstnameFieldWarn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.firstnameFieldWarn.Location = new System.Drawing.Point(687, 158);
            this.firstnameFieldWarn.Name = "firstnameFieldWarn";
            this.firstnameFieldWarn.Size = new System.Drawing.Size(51, 20);
            this.firstnameFieldWarn.TabIndex = 14;
            this.firstnameFieldWarn.Text = "label2";
            this.firstnameFieldWarn.Visible = false;
            // 
            // lastnameFieldWarn
            // 
            this.lastnameFieldWarn.AutoSize = true;
            this.lastnameFieldWarn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lastnameFieldWarn.Location = new System.Drawing.Point(687, 220);
            this.lastnameFieldWarn.Name = "lastnameFieldWarn";
            this.lastnameFieldWarn.Size = new System.Drawing.Size(51, 20);
            this.lastnameFieldWarn.TabIndex = 15;
            this.lastnameFieldWarn.Text = "label3";
            this.lastnameFieldWarn.Visible = false;
            // 
            // phoneNumberFieldWarn
            // 
            this.phoneNumberFieldWarn.AutoSize = true;
            this.phoneNumberFieldWarn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.phoneNumberFieldWarn.Location = new System.Drawing.Point(687, 285);
            this.phoneNumberFieldWarn.Name = "phoneNumberFieldWarn";
            this.phoneNumberFieldWarn.Size = new System.Drawing.Size(51, 20);
            this.phoneNumberFieldWarn.TabIndex = 16;
            this.phoneNumberFieldWarn.Text = "label4";
            this.phoneNumberFieldWarn.Visible = false;
            // 
            // emailFieldWarn
            // 
            this.emailFieldWarn.AutoSize = true;
            this.emailFieldWarn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.emailFieldWarn.Location = new System.Drawing.Point(687, 350);
            this.emailFieldWarn.Name = "emailFieldWarn";
            this.emailFieldWarn.Size = new System.Drawing.Size(51, 20);
            this.emailFieldWarn.TabIndex = 17;
            this.emailFieldWarn.Text = "label5";
            this.emailFieldWarn.Visible = false;
            // 
            // educationComboBoxWarn
            // 
            this.educationComboBoxWarn.AutoSize = true;
            this.educationComboBoxWarn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.educationComboBoxWarn.Location = new System.Drawing.Point(307, 404);
            this.educationComboBoxWarn.Name = "educationComboBoxWarn";
            this.educationComboBoxWarn.Size = new System.Drawing.Size(51, 20);
            this.educationComboBoxWarn.TabIndex = 18;
            this.educationComboBoxWarn.Text = "label6";
            // 
            // addressFieldWarn
            // 
            this.addressFieldWarn.AutoSize = true;
            this.addressFieldWarn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.addressFieldWarn.Location = new System.Drawing.Point(687, 549);
            this.addressFieldWarn.Name = "addressFieldWarn";
            this.addressFieldWarn.Size = new System.Drawing.Size(51, 20);
            this.addressFieldWarn.TabIndex = 19;
            this.addressFieldWarn.Text = "label7";
            this.addressFieldWarn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(840, 891);
            this.Controls.Add(this.addressFieldWarn);
            this.Controls.Add(this.educationComboBoxWarn);
            this.Controls.Add(this.emailFieldWarn);
            this.Controls.Add(this.phoneNumberFieldWarn);
            this.Controls.Add(this.lastnameFieldWarn);
            this.Controls.Add(this.firstnameFieldWarn);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.educationComboBox);
            this.Controls.Add(this.addressField);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.phoneNumberField);
            this.Controls.Add(this.lastnameField);
            this.Controls.Add(this.firstnameField);
            this.Controls.Add(this.educationLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.firstnameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label educationLabel;
        private System.Windows.Forms.TextBox firstnameField;
        private System.Windows.Forms.TextBox lastnameField;
        private System.Windows.Forms.TextBox phoneNumberField;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.ComboBox educationComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label firstnameFieldWarn;
        private System.Windows.Forms.Label lastnameFieldWarn;
        private System.Windows.Forms.Label phoneNumberFieldWarn;
        private System.Windows.Forms.Label emailFieldWarn;
        private System.Windows.Forms.Label educationComboBoxWarn;
        private System.Windows.Forms.Label addressFieldWarn;
    }
}

