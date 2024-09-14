using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Org.BouncyCastle.Utilities;

namespace Personal_Info_Form
{
    public class MyDBContext : DbContext
    {
        public string ConnectionString { get; }

        public AppDbContext()
        {
            string ConnectionString = "Server=localhost;Database=personal_info;User=root;Password=(13Am-iR77)/[!#19_98&*];";

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySQL(ConnectionString);
        }
    }



    public partial class Form1 : Form
    {

        List<Label> warnLabels = new List<Label>();
        List<TextBox> textBoxes = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();
            warnLabels = new List<Label> { firstnameFieldWarn, lastnameFieldWarn, phoneNumberFieldWarn, emailFieldWarn, educationComboBoxWarn, addressFieldWarn };
            textBoxes = new List<TextBox> { firstnameField, lastnameField, phoneNumberField, emailField, addressField };
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            bool submitAllowed = false;
            foreach (Label label in warnLabels)
            {
                if (label.Visible)
                {
                    submitAllowed = true;
                }
            }
            foreach (TextBox field in textBoxes)
            {
                if (field.Text == "")
                {
                    submitAllowed = true;
                }
            }

            if (!submitAllowed)
            {
                MessageBox.Show("Please fill all the fields correctly!");
            }
            else
            {

            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            try
            {
                TextBox field = (TextBox)sender;
                if (field.Text == "")
                {
                    field.BackColor = Color.Salmon;

                    foreach (Label label in warnLabels)
                    {
                        if (label.Name == $"{field.Name}Warn")
                        {
                            label.ForeColor = Color.Red;
                            label.Text = "Field can't be empty";
                            label.Visible = true;
                        }
                    }
                }
            }
            catch
            {
                ComboBox comboBox = (ComboBox)sender;
                if (comboBox.Text == "")
                {
                    comboBox.BackColor = Color.Salmon;
                    educationComboBoxWarn.ForeColor = Color.Red;
                    educationComboBoxWarn.Text = "Field can't be empty";
                    educationComboBoxWarn.Visible = true;
                }
                else
                {
                    comboBox.BackColor = SystemColors.Window;
                }
            }
        }

        private void addressField_TextChanged(object sender, EventArgs e)
        {

            try
            {
                TextBox field = (TextBox)sender;
                if (field.Text == "")
                {
                    foreach (Label label in warnLabels)
                    {
                        if (label.Name == field.Name + "Warn")
                        {
                            label.ForeColor = Color.Red;
                            label.Text = "Field can't be empty";
                            label.Visible = true;
                        }
                    }
                }

                else
                {
                    foreach (Label label in warnLabels)
                    {
                        if (label.Name == field.Name + "Warn")
                        {
                            if (field.Name == "firstnameField" && field.Text.Length > 10)
                            {
                                firstnameFieldWarn.ForeColor = Color.Yellow;
                                firstnameFieldWarn.Text = "More than 10 chars";
                                firstnameFieldWarn.Visible = true;
                            }
                            else if (field.Name == "lastnameField" && field.Text.Length > 10)
                            {
                                lastnameFieldWarn.ForeColor = Color.Yellow;
                                lastnameFieldWarn.Text = "More than 10 chars";
                                lastnameFieldWarn.Visible = true;
                            }
                            else if (field.Name == "phoneNumberField" && field.Text.Length != 10)
                            {
                                phoneNumberFieldWarn.ForeColor = Color.Yellow;
                                phoneNumberFieldWarn.Text = "Not a phone number";
                                phoneNumberFieldWarn.Visible = true;
                            }
                            else if (field.Name == "emailField" && !field.Text.Contains("@gmail.com"))
                            {
                                emailFieldWarn.ForeColor = Color.Yellow;
                                emailFieldWarn.Text = "Not an email";
                                emailFieldWarn.Visible = true;
                            }
                            else
                            {
                                label.Visible = false;
                                field.BackColor = SystemColors.Window;
                            }
                        }
                    }
                }
            }
            catch
            {
                ComboBox comboBox = (ComboBox)sender;
                if (comboBox.Text == "")
                {
                    foreach (Label label in warnLabels)
                    {
                        if (label.Name == comboBox.Name + "Warn")
                        {
                            label.ForeColor = Color.Red;
                            label.Text = "Field can't be empty";
                            label.Visible = true;
                        }
                    }
                }
                else
                {
                    comboBox.BackColor = SystemColors.Window;
                    foreach (Label label in warnLabels)
                    {
                        if (label.Name == comboBox.Name + "Warn")
                        {
                            label.Visible = false;
                        }
                    }
                }
            }
        }
    }
}
