﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cardID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "2 of clubs";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "2 of diamonds";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "2 of hearts";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label1.Text = "2 of spades";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label1.Text = "3 of clubs";
        }
    }
}
