using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Lab4 : Form
    {
        public Lab4()
        {
            InitializeComponent();
        }

        private int score = 0;
        private int product = 0;
        private int answer = 0;

        
        private void SubmitButton_Click(object sender, EventArgs e)
        {

            try
            {
                answer = int.Parse(AnswerTextBox.Text);
                if (answer == product)
                {                 
                    MessageBox.Show("Correct!");                   
                }
                else
                {
                    MessageBox.Show("Sorry, your answer is incorrect!");
                }

            }
            catch
            {
                MessageBox.Show("There was an error processing your answer!");
            }

            if (answer == product)
            {
                score = score + 20;
                ScoreLabel.Text = "Score: " + score.ToString();
            }

        }
        


        private void NewButton_Click(object sender, EventArgs e)
        {

            int var1 = 0;
            int var2 = 0;

            Random rand = new Random();

            var1 = rand.Next(10);
            var2 = rand.Next(10);

            PromptLabel.Text = "What is " + var1.ToString() + " . " + var2.ToString() + "?";

            product = var1 * var2;

            for (int count = 10; count >=1; count--)
            {
                TimeLabel.Text = count.ToString();
                MessageBox.Show("You have " + count.ToString() + " sec left!");
            }

        }
    }
}
