using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int totalAmt = 0;
        int total = 0;

        private void spinButton_Click(object sender, EventArgs e)
        {
            int amt = 0;
            int win = 0;
            int val1 = 0;
            int val2 = 0;
            int val3 = 0;

            amt = int.Parse(AmountTextBox.Text);

            Random rand = new Random();
            int index = rand.Next(fruitImageList.Images.Count);
            pictureBox1.Image = fruitImageList.Images[index];
            val1 = index;

            index = rand.Next(fruitImageList.Images.Count);
            pictureBox2.Image = fruitImageList.Images[index];
            val2 = index;

            index = rand.Next(fruitImageList.Images.Count);
            pictureBox3.Image = fruitImageList.Images[index];
            val3 = index;

            totalAmt = totalAmt + amt;

            try
            {
                if (val1 == val2 || val1 == val3 || val2 == val3)
                {
                    win = amt * 2;
                    total = total + win;
                    MessageBox.Show("You won $" + win);
                }
                else
                    if (val1 == val2 && val1 == val3)
                {
                    win = amt * 3;
                    total = total + win;
                    MessageBox.Show("You won $" + win);
                }
                else
                    MessageBox.Show("You lose");
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid amount");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You spent $" + totalAmt + " and won $" + total);
            this.Close();
        }
    }
}
