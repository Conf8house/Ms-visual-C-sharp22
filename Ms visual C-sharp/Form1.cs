﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            base.Text = "Helow";
            label1.Text  = "Microsoft Visual C# 12";
            label2.Text = "Microsoft Visual C# 12";
            button1.Text  = "Press me";
            tabPage1.Text = "C#";
            tabPage2.Text = "Hover";
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            MessageBox .Show ("Hallow everyone");
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Event of Hover!");
        }

    }
}
