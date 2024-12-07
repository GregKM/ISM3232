using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void francePictureBox_Click(object sender, EventArgs e)
        {
            currencyLabel.Text = "€88.17";
        }

        private void mexicoPictureBox_Click(object sender, EventArgs e)
        {
            currencyLabel.Text = "$1681.08";
        }
    }
}
