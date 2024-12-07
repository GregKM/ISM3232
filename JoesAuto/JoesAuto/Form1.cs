using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoesAuto
{
    public partial class Form1 : Form
    {

        bool oilFlag = false;
        bool lubeFlag = false;
        bool radFlag = false;
        bool transFlag = false;
        bool insFlag = false;
        bool mufflerFlag = false;
        bool tireFlag = false;

        decimal lubeTotal = 0m;
        decimal flushTotal = 0m;
        decimal miscTotal = 0m;
        decimal otherTotal = 0m;
        decimal taxTotal = 0m;
        decimal totalCharge = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private decimal OilLubeCharges(ref decimal total)
        {
            total = 0m;
            if (oilFlag)
            {
                total = total + 26;
            }

            if (lubeFlag)
            {
                total = total + 18;
            }

            return total;
        }

        private decimal FlushCharges(ref decimal total)
        {
            total = 0m;
            if (radFlag)
            {
                total = total + 30;
            }

            if (transFlag)
            {
                total = total + 80;
            }

            return total;
        }

        private decimal MiscCharges(ref decimal total)
        {
            total = 0m;
            if (insFlag)
            {
                total = total + 15;
            }

            if (mufflerFlag)
            {
                total = total + 100;
            }

            if (tireFlag)
            {
                total = total + 20;
            }

            return total;
        }

        private decimal OtherCharges(ref decimal total)
        {
            total = 0m;
            decimal miscLabor = 0m;
            decimal miscParts = 0m;
            if (partsTextBox.Text != "")
            {
                try
                {
                    miscParts = decimal.Parse(partsTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Enter a valid number");
                }
            }

            if (laborTextBox.Text != "")
            {
                try
                {
                    miscLabor = decimal.Parse(laborTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Enter a valid number");
                }
            }

            total = miscParts + miscLabor;
            return total;
        }

        private decimal TaxCharges(ref decimal total)
        {
            decimal tax = .06m;
            decimal parts = 0m;
            if (partsTextBox.Text != "")
            {
                try
                {
                    parts = decimal.Parse(partsTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Enter a valid number");
                }
            }

            total = parts * tax;
            return total;
        }

        private decimal TotalCharges(ref decimal total)
        {
            total = lubeTotal + flushTotal + miscTotal + otherTotal + taxTotal;
            return total;
        }

        private void ClearOilLube()
        {
            if (oilChangeCheckBox.Checked == true)
            {
                oilChangeCheckBox.Checked = false;
            }

            if (lubeJobCheckBox.Checked == true)
            {
                lubeJobCheckBox.Checked = false;
            }
        }

        private void ClearFlushes()
        {
            if (radiatorFlushCheckBox.Checked == true)
            {
                radiatorFlushCheckBox.Checked = false;
            }

            if (transFlushCheckBox.Checked == true)
            {
                transFlushCheckBox.Checked = false;
            }
        }

        private void ClearOther()
        {
            if (partsTextBox.Text != "")
                partsTextBox.Text = "";

            if (laborTextBox.Text != "")
                laborTextBox.Text = "";
        }

        private void ClearMisc()
        {
            if (inspectionCheckBox.Checked == true)
                inspectionCheckBox.Checked = false;

            if (replaceMufflerCheckBox.Checked == true)
                replaceMufflerCheckBox.Checked = false;

            if (tireRotationCheckBox.Checked == true)
                tireRotationCheckBox.Checked = false;
        }

        private void ClearFees()
        {
            servicesLaborTextBox.Text = "";
            partsSummaryTextBox.Text = "";
            taxTextBox.Text = "";
            totalFeesTextBox.Text = "";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal servicesTotal = 0m;
            decimal miscLabor = 0m;
            decimal miscParts = 0m;

            OilLubeCharges(ref lubeTotal);
            FlushCharges(ref flushTotal);
            MiscCharges(ref miscTotal);
            OtherCharges(ref otherTotal);
            TaxCharges(ref taxTotal);
            TotalCharges(ref totalCharge);

            if (laborTextBox.Text != "")
            {
                try
                {
                    miscLabor = decimal.Parse(laborTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Enter a valid number");
                }
            }

            servicesTotal = lubeTotal + flushTotal + miscTotal + miscLabor;

            servicesLaborTextBox.Text = servicesTotal.ToString("c");

            if (partsTextBox.Text != "")
            {
                try
                {
                    miscParts = decimal.Parse(partsTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Enter a valid number");
                }
            }

            partsSummaryTextBox.Text = miscParts.ToString("c");

            taxTextBox.Text = taxTotal.ToString("c");

            totalFeesTextBox.Text = totalCharge.ToString("c");

        }

        private void oilChangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (oilFlag == false)
            {
                oilFlag = true;
            }
            else
            {
                oilFlag = false;
            }
        }

        private void lubeJobCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lubeFlag == false)
            {
                lubeFlag = true;
            }
            else
            {
                lubeFlag = false;
            }
        }

        private void radiatorFlushCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (radFlag == false)
            {
                radFlag = true;
            }
            else
            {
                radFlag = false;
            }
        }

        private void transFlushCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (transFlag == false)
            {
                transFlag = true;
            }
            else
            {
                transFlag = false;
            }
        }

        private void inspectionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (insFlag == false)
            {
                insFlag = true;
            }
            else
            {
                insFlag = false;
            }
        }

        private void replaceMufflerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mufflerFlag == false)
            {
                mufflerFlag = true;
            }
            else
            {
                mufflerFlag = false;
            }
        }

        private void tireRotationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tireFlag == false)
            {
                tireFlag = true;
            }
            else
            {
                tireFlag = false;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFees();
            ClearOther();
            ClearMisc();
            ClearFlushes();
            ClearOilLube();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
