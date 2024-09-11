using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curiousity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameField.Text == "" || phoneField.Text == "" || stuNumField.Text == "" || meanScoreField.Text == "")
            {
                messageLable.Text = "Field Shouldn't be empty!";
            }
            else
            {
                
            }
        }

        private void Field_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text == "")
            {
                MessageBox.Show("Field Shouldn't be empty!");
            }
        }
    }
}
