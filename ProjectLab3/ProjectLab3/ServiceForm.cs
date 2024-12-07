using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLab3
{
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            try
            {
                double TotalFee = 0;

                if (fleaRemovalCheckBox.Checked)
                {
                    TotalFee = 5;
                }
                if (shampooCheckBox.Checked)
                {
                    TotalFee = 4;
                }
                if (fleaRemovalCheckBox.Checked && shampooCheckBox.Checked)
                {
                    TotalFee = 9;
                }

                priceLabel.Text = TotalFee.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ownerNameTextBox.Text = "";
            ownerPhoneTextBox.Text = "";
            petNameTextBox.Text = "";
            petDOBTextBox.Text = "";

            ownerNameTextBox.Focus();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
