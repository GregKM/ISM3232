using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadsTails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void headsButton_Click(object sender, EventArgs e)
        {
            tailsBox.Visible = false;
            headsBox.Visible = true;
        }

        private void tailsButton_Click(object sender, EventArgs e)
        {
            headsBox.Visible = false;
            tailsBox.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
