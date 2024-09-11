using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox1.Text == "0" || textBox2.Text == "0")
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

                ResultLable.ForeColor = Color.Red;
                ResultLable.Text = "!";
                MessageLable.Enabled = true;
                MessageLable.Visible = true;
                MessageLable.ForeColor = Color.Yellow;
                MessageLable.Text = "Both fields should have non-zero value.";
            }

            else
            {
                MessageLable.Visible = false;
                ResultLable.ForeColor = Color.Aqua;
                string operation = button.Text;
                if (operation == "+")
                {
                    ResultLable.Text = $"{Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)}";
                }
                if (operation == "*")
                {
                    ResultLable.Text = $"{Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)}";
                }
                if (operation == "-")
                {
                    ResultLable.Text = $"{Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)}";
                }
                if (operation == "/")
                {
                    ResultLable.Text = $"{Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text)}";
                }
            }
        }
    }
}
