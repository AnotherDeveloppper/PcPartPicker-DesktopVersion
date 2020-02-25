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
    public partial class PickCpuCooler : UserControl
    {
        databeuseDataContext db = new databeuseDataContext();
        public PickCpuCooler()
        {
            InitializeComponent();
            CpuCooler("");

        }

        int poss = 10;
        public void addItem(string text, string path)
        {
            AddPart p = new PcPartPicker_Desktop_Version.AddPart(text, path);
            panel1.Controls.Add(p);
            p.Top = poss;
            poss = (p.Top + p.Height + 5);

        }
        public void CpuCooler(String Filter)
        {
            List<CpuCooler> b3 = new List<CpuCooler>();
            var q3 = (from a in db.CpuCoolers
                      where a.CpuCooler_ID.Contains(Filter)
                      select a).ToList();
            b3 = q3;
            dataGridView1.DataSource = b3;

            int i3 = b3.Count();
            for (int a = 0; a < i3; a++)
            {

                string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                addItem(c, "CpuCooler");
            }
        }

        private void cbAMD_OnChange(object sender, EventArgs e)
        {
            clears();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            poss = 10;
            panel1.Controls.Clear();
            clears();
        }


        public void clears()
        {
            poss = 10;
            panel1.Controls.Clear();
            string a = bunifuMaterialTextbox1.Text;
            if (cbAMD.Checked) CpuCoolers("NO",a);
            if (cbIntel.Checked) CpuCoolers("yes-120mm",a);
            if (cb240.Checked) CpuCoolers("yes-240mm",a);
            if (cb360.Checked) CpuCoolers("yes-360mm",a);
        }
        public void CpuCoolers(string Filter,string name)
        {
            List<CpuCooler> b3 = new List<CpuCooler>();
            var q3 = (from a in db.CpuCoolers
                      where a.Water_Cooled.Contains(Filter) && a.CpuCooler_ID.Contains(name)
                      select a).ToList();
            b3 = q3;
            dataGridView1.DataSource = b3;

            int i3 = b3.Count();
            for (int a = 0; a < i3; a++)
            {

                string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                addItem(c, "CpuCooler");
            }
        }

        private void cbIntel_OnChange(object sender, EventArgs e)
        {

            clears();
        }

        private void cb240_OnChange(object sender, EventArgs e)
        {

            clears();
        }

        private void cb360_OnChange(object sender, EventArgs e)
        {

            clears();
        }

        private void cbIntel_OnChange_1(object sender, EventArgs e)
        {
            clears();
        }
    }
}
