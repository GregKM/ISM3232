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

namespace NameSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int SequentialSearch(string[] sArray, string value)
        {
            bool found = false;
            int index = 0;
            int position = -1;

            while (!found && index < sArray.Length)
            {
                if (sArray[index] == value)
                {
                    found = true;
                    position = index;
                }

                index++;
            
            }

            return position;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string bName = boyTextBox.Text;
            string gName = girlTextBox.Text;

            const int SIZE = 200;

            string[] boyNames = new string[SIZE];
            string[] girlNames = new string[SIZE];

            int index = 0;

            StreamReader girlFile;
            StreamReader boyFile;

            girlFile = File.OpenText("GirlNames.txt");

            while (index < girlNames.Length && !girlFile.EndOfStream)
            {
                girlNames[index] = girlFile.ReadLine();
                index++;
            }

            girlFile.Close();

            boyFile = File.OpenText("BoyNames.txt");

            while (index < boyNames.Length && !boyFile.EndOfStream)
            {
                boyNames[index] = boyFile.ReadLine();
                index++;
            }

            boyFile.Close();

            if (SequentialSearch(girlNames, gName) != -1)
            {
                MessageBox.Show("Yes. That girl name is there.");
            }
            else
            {
                MessageBox.Show("Nope. Not that girl name.");
            }

            if (SequentialSearch(boyNames, bName) != -1)
            {
                MessageBox.Show("Yes. That boy name is there.");
            }
            else
            {
                MessageBox.Show("Nope. Not that boy name.");
            }
        }
    }
}
