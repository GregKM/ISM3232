using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                const decimal PACKAGE = 99;
                const decimal RATE1 = .2m;
                const decimal RATE2 = .3m;
                const decimal RATE3 = .4m;
                const decimal RATE4 = .5m;

                decimal quantPurchased = 0;

                decimal discountTotal = 0;
                decimal total = 0;

                quantPurchased = decimal.Parse(numberTextBox.Text);

                if (quantPurchased < 10)
                {
                    discountTextBox.Text = "No Discount";
                    total = quantPurchased * PACKAGE;
                    totalTextBox.Text = total.ToString("c");
                }
                else if (quantPurchased < 20)
                {
                    discountTextBox.Text = "20%";
                    discountTotal = (quantPurchased * PACKAGE) * RATE1;
                    total = (quantPurchased * PACKAGE) - discountTotal;
                    totalTextBox.Text = total.ToString("c");
                }
                else if (quantPurchased < 50)
                {
                    discountTextBox.Text = "30%";
                    discountTotal = (quantPurchased * PACKAGE) * RATE2;
                    total = (quantPurchased * PACKAGE) - discountTotal;
                    totalTextBox.Text = total.ToString("c");
                }
                else if (quantPurchased < 100)
                {
                    discountTextBox.Text = "40%";
                    discountTotal = (quantPurchased * PACKAGE) * RATE3;
                    total = (quantPurchased * PACKAGE) - discountTotal;
                    totalTextBox.Text = total.ToString("c");
                }
                else
                {
                    discountTextBox.Text = "50%";
                    discountTotal = (quantPurchased * PACKAGE) * RATE4;
                    total = (quantPurchased * PACKAGE) - discountTotal;
                    totalTextBox.Text = total.ToString("c");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Text = "";
            discountTextBox.Text = "";
            totalTextBox.Text = "";
            numberTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
