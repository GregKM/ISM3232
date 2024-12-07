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
    public partial class MainForm : Form
    {

        const int HALL1 = 1500;
        const int HALL2 = 1600;
        const int HALL3 = 1800;
        const int HALL4 = 2500;

        const int MEAL1 = 600;
        const int MEAL2 = 1200;
        const int MEAL3 = 1700;

        int hall = 0;
        int meal = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (dormComboBox.SelectedIndex == 0)
            {
                hall = HALL1;
            }

            if (dormComboBox.SelectedIndex == 1)
            {
                hall = HALL2;
            }

            if (dormComboBox.SelectedIndex == 2)
            {
                hall = HALL3;
            }

            if (dormComboBox.SelectedIndex == 3)
            {
                hall = HALL4;
            }

            if (mealComboBox.SelectedIndex == 0)
            {
                meal = MEAL1;
            }

            if (mealComboBox.SelectedIndex == 1)
            {
                meal = MEAL2;
            }

            if (mealComboBox.SelectedIndex == 2)
            {
                meal = MEAL3;
            }

            DataClass.total = hall + meal;

            TotalForm myTotalForm = new TotalForm();

            myTotalForm.ShowDialog();

        }
    }
}
