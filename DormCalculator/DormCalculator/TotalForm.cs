using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormCalculator
{
    public partial class TotalForm : Form
    {
        public TotalForm()
        {
            InitializeComponent();
        }

        private void TotalForm_Load(object sender, EventArgs e)
        {
            totalTextBox.Text = DataClass.total.ToString("c");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
