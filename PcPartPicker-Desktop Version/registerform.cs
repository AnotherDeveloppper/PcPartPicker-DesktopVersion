﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcPartPicker_Desktop_Version
{
    public partial class registerform : Form
    {
        public registerform()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginScreen l = new LoginScreen();
            l.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void registerform_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            LoginScreen l = new LoginScreen();
            l.Show();
            this.Hide();
        }
    }
}
