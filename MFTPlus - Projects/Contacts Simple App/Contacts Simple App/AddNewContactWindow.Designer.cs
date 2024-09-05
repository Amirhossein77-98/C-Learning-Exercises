namespace Contacts_Simple_App
{
    partial class AddNewContactWindow
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
            this.AppTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contactsFirstNameField = new System.Windows.Forms.TextBox();
            this.contactsLastNameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contactsPhoneNumberField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AppTitle
            // 
            this.AppTitle.AutoSize = true;
            this.AppTitle.BackColor = System.Drawing.Color.Transparent;
            this.AppTitle.Font = new System.Drawing.Font("Doppio One", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AppTitle.Location = new System.Drawing.Point(147, 9);
            this.AppTitle.Name = "AppTitle";
            this.AppTitle.Size = new System.Drawing.Size(444, 62);
            this.AppTitle.TabIndex = 1;
            this.AppTitle.Text = "Add New Contact";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Inter", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(26, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name:";
            // 
            // contactsFirstNameField
            // 
            this.contactsFirstNameField.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contactsFirstNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactsFirstNameField.Location = new System.Drawing.Point(34, 227);
            this.contactsFirstNameField.Multiline = true;
            this.contactsFirstNameField.Name = "contactsFirstNameField";
            this.contactsFirstNameField.Size = new System.Drawing.Size(665, 40);
            this.contactsFirstNameField.TabIndex = 3;
            this.contactsFirstNameField.Text = "e.g Amirhossein...";
            this.contactsFirstNameField.WordWrap = false;
            this.contactsFirstNameField.Enter += new System.EventHandler(this.contactsFirstNameField_Enter);
            this.contactsFirstNameField.Leave += new System.EventHandler(this.contactsFirstNameField_Leave);
            // 
            // contactsLastNameField
            // 
            this.contactsLastNameField.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contactsLastNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.contactsLastNameField.Location = new System.Drawing.Point(34, 353);
            this.contactsLastNameField.Multiline = true;
            this.contactsLastNameField.Name = "contactsLastNameField";
            this.contactsLastNameField.Size = new System.Drawing.Size(665, 40);
            this.contactsLastNameField.TabIndex = 5;
            this.contactsLastNameField.Text = "e.g Gholizadeh...";
            this.contactsLastNameField.Enter += new System.EventHandler(this.contactsLastNameField_Enter);
            this.contactsLastNameField.Leave += new System.EventHandler(this.contactsLastNameField_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Inter", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(26, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name:";
            // 
            // contactsPhoneNumberField
            // 
            this.contactsPhoneNumberField.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contactsPhoneNumberField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.contactsPhoneNumberField.Location = new System.Drawing.Point(34, 478);
            this.contactsPhoneNumberField.Multiline = true;
            this.contactsPhoneNumberField.Name = "contactsPhoneNumberField";
            this.contactsPhoneNumberField.Size = new System.Drawing.Size(665, 40);
            this.contactsPhoneNumberField.TabIndex = 7;
            this.contactsPhoneNumberField.Text = "e.g 093123456789...";
            this.contactsPhoneNumberField.Enter += new System.EventHandler(this.contactsPhoneNumberField_Enter);
            this.contactsPhoneNumberField.Leave += new System.EventHandler(this.contactsPhoneNumberField_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Inter", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(26, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone Number:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(280, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewContactWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(740, 845);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contactsPhoneNumberField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contactsLastNameField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contactsFirstNameField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddNewContactWindow";
            this.Text = "AddNewContactWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contactsLastNameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox contactsPhoneNumberField;
        private System.Windows.Forms.TextBox contactsFirstNameField;
    }
}