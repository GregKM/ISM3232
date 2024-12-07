using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCounter
{
    public partial class Form1 : Form
    {

        const int NANA = 115;
        const int APPLE = 80;
        const int ORANGE = 90;
        const int PEAR = 120;
        int calTotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            calTotal = 0;
            calorieTextBox.Text = calTotal.ToString();
        }

        private void bananaBox_Click(object sender, EventArgs e)
        {
            calTotal = calTotal + NANA;
            calorieTextBox.Text = calTotal.ToString();
        }

        private void appleBox_Click(object sender, EventArgs e)
        {
            calTotal = calTotal + APPLE;
            calorieTextBox.Text = calTotal.ToString();
        }

        private void orangeBox_Click(object sender, EventArgs e)
        {
            calTotal = calTotal + ORANGE;
            calorieTextBox.Text = calTotal.ToString();
        }

        private void pearBox_Click(object sender, EventArgs e)
        {
            calTotal = calTotal + PEAR;
            calorieTextBox.Text = calTotal.ToString();
        }
    }
}
