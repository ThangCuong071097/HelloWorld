﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MinimumSize = new Size(lblHelloWorld.Width,lblHelloWorld.Width);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World!";
            lblHelloWorld.Left = (ClientSize.Width - lblHelloWorld.Width) / 2;
            lblHelloWorld.Top = (ClientSize.Height - lblHelloWorld.Height) / 2;

        }
    }
}
