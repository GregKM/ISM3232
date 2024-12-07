using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemographicAnalyticalReports
{
    public partial class FormReports : Form
    {
        public FormReports()
        {
            InitializeComponent();
        }

        private void FormReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorks2012_DataDataSet.vPersonDemographics' table. You can move, or remove it, as needed.
            this.vPersonDemographicsTableAdapter.Fill(this.adventureWorks2012_DataDataSet.vPersonDemographics);

        }

        private void demographicReportOptionsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vPersonDemographicsTableAdapter.DemographicReportOptions(this.adventureWorks2012_DataDataSet.vPersonDemographics, maritalStatusToolStripTextBox.Text, genderToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(totalChildrenToolStripTextBox.Text, typeof(int))))), educationToolStripTextBox.Text, occupationToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void buttonExitReports_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
