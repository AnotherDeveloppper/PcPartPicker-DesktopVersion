using System;
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
    public partial class AllParts : UserControl
    {
        public AllParts()
        {
            InitializeComponent();
        }

        int poss = 10;
        public void addItem(string text)
        {
            Part p = new PcPartPicker_Desktop_Version.Part(text);
            panel2.Controls.Add(p);
            p.Top = poss;
            poss = (p.Top + p.Height + 5 );

        }

        private void AllParts_Load(object sender, EventArgs e)
        {
            addItem("PSU");
            addItem("MOTHERBOARD");
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
        }
    }
}
