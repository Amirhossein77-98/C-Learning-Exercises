using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Guessing_Game
{
    public partial class Form1 : Form
    {
        List<TextBox> textBoxes = new List<TextBox>();
        Random random = new Random();
        int winCount = 0;
        int loseCount = 0;
        int counter = 5;
        int rounds = 0;
        int number1;
        int number2;
        int number3;
        int number4;
        public Form1()
        {
            InitializeComponent();
            textBoxes = new List<TextBox>() { textBox1, textBox2, textBox3, textBox4 };
            RandomNumberGenerator();
        }

        private void RandomNumberGenerator()
        {
            number1 = random.Next(0, 10);
            number2 = random.Next(0, 10);
            number3 = random.Next(0, 10);
            number4 = random.Next(0, 10);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int box1 = Convert.ToInt32(textBox1.Text);
            int box2 = Convert.ToInt32(textBox2.Text);
            int box3 = Convert.ToInt32(textBox3.Text);
            int box4 = Convert.ToInt32(textBox4.Text);

            if (box1 == number1 && box2 == number2 && box3 == number3 && box4 == number4 && counter > 0)
            {
                winCount++;
                winsLabel.Text = winCount.ToString();
                rounds++;
                RoundsLabel.Text = rounds.ToString();
                counter = 5;
                label3.Text = counter.ToString();

                MessageBox.Show("You Win!");

                textBox1.BackColor = SystemColors.Window;
                textBox2.BackColor = SystemColors.Window;
                textBox3.BackColor = SystemColors.Window;
                textBox4.BackColor = SystemColors.Window;

                ResetGame();
                counter--;
                return;
            }

            counter--;
            label3.Text = counter.ToString();
            if (counter < 1)
            {
                loseCount++;
                LosesLabel.Text = loseCount.ToString();
                rounds++;
                RoundsLabel.Text = rounds.ToString();
                counter = 5;
                label3.Text = counter.ToString();

                MessageBox.Show($"You Lose\nAnswer: {number1.ToString() + number2.ToString() + number3.ToString() + number4.ToString()}");

                textBox1.BackColor = SystemColors.Window;
                textBox2.BackColor = SystemColors.Window;
                textBox3.BackColor = SystemColors.Window;
                textBox4.BackColor = SystemColors.Window;
                ResetGame();
                return;
            }

            foreach (TextBox box in textBoxes)
            {
                if (box.Text == "")
                {
                    MessageBox.Show("Please fill all the boxes!");
                    return;
                }
            }


            // Box 1 Checking
            if (box1 == number1)
            {
                textBox1.BackColor = Color.Green;
            }
            else if (box1 == number2 || box1 == number3 || box1 == number4)
            {
                textBox1.BackColor = Color.SkyBlue;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            // Box 2 Checking
            if (box2 == number2)
            {
                textBox2.BackColor = Color.Green;
            }
            else if (box2 == number1 || box2 == number3 || box2 == number4)
            {
                textBox2.BackColor = Color.SkyBlue;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            // Box 3 Checking
            if (box3 == number3)
            {
                textBox3.BackColor = Color.Green;
            }
            else if (box3 == number1 || box3 == number2 || box3 == number4)
            {
                textBox3.BackColor = Color.SkyBlue;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            // Box 4 Checking
            if (box4 == number4)
            {
                textBox4.BackColor = Color.Green;
            }
            else if (box4 == number1 || box4 == number2 || box4 == number3)
            {
                textBox4.BackColor = Color.SkyBlue;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
        }

        private void ResetGame()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            RandomNumberGenerator();
        }
    }
}
