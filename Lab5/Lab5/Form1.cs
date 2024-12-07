using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// Programmer: Greg Mathews
// Project: Lab 5
// Date: 11/08/2015
// Description: Sales figure calculator

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadSales(List<decimal> salesList)
        {
            try
            {
                StreamReader inputFile = File.OpenText("Sales.txt");

                while (!inputFile.EndOfStream)
                {
                    salesList.Add(decimal.Parse(inputFile.ReadLine()));
                }

                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplaySales(List<decimal> salesList)
        {
            foreach (decimal sale in salesList)
            {
                salesListBox.Items.Add(sale);
            }
        }

        private decimal Average(List<decimal> salesList)
        {
            decimal total = 0m;
            decimal average;

            foreach (decimal sale in salesList)
            {
                total += sale;
            }

            average = total / salesList.Count;

            return average;
        }

        private decimal AboveAverage(List<decimal> salesList)
        {
            decimal numAbove = 0m;

            decimal avg = Average(salesList);

            foreach (decimal sale in salesList)
            {
                if (sale > avg)
                {
                    numAbove++;
                }
            }

            return numAbove;
        }

        private decimal BelowAverage(List<decimal> salesList)
        {
            decimal numBelow = 0m;

            decimal avg = Average(salesList);

            foreach (decimal sale in salesList)
            {
                if (sale < avg)
                {
                    numBelow++;
                }
            }

            return numBelow;
        }

        private decimal Total(List<decimal> salesList)
        {
            decimal total = 0m;

            foreach (decimal sale in salesList)
            {
                total += sale;
            }

            return total;
        }

        private void loadSalesButton_Click(object sender, EventArgs e)
        {
            decimal averageSale;
            decimal numAboveAverage;
            decimal numBelowAverage;
            decimal totalSale;

            List<decimal> salesList = new List<decimal>();

            ReadSales(salesList);

            DisplaySales(salesList);

            averageSale = Average(salesList);
            averageTextBox.Text = averageSale.ToString("c");

            numAboveAverage = AboveAverage(salesList);
            maxTextBox.Text = numAboveAverage.ToString("c");

            numBelowAverage = BelowAverage(salesList);
            minTextBox.Text = numBelowAverage.ToString("c");

            totalSale = Total(salesList);
            totalTextBox.Text = totalSale.ToString("c");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            salesListBox.Items.Clear();
            averageTextBox.Text = "";
            maxTextBox.Text = "";
            minTextBox.Text = "";
            totalTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
