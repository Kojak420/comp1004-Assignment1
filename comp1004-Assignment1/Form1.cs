﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp1004_Assignment1
{
    public partial class Lab1Form : Form
    {
        public Lab1Form()
        {
            InitializeComponent();
        }

        private void NothingButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Lab1Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
