﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcPartPicker_Desktop_Version
{
    public partial class Part : UserControl
    {
        public Part()
        {
            InitializeComponent();
        }

        public Part(string Text)
        {
            InitializeComponent();
            lbItemName.Text = Text;
        }

        public Part(string text ,string Path)
        {
            InitializeComponent();
            lbItemName.Text = Text;

        }
    }
}
