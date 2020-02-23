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
    public partial class PickCpu : UserControl
    {
        databeuseDataContext db = new databeuseDataContext();
        public PickCpu()
        {
            InitializeComponent();
            cpu("");
        }
        int poss = 10;


        public void addItem(string text, string path)
        {
            AddPart p = new PcPartPicker_Desktop_Version.AddPart(text, path);
            panel1.Controls.Add(p);
            p.Top = poss;
            poss = (p.Top + p.Height + 5);

        }
        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        public void cpu(String Filter)
        {
            List<Cpu> b1 = new List<Cpu>();
            var q1 = (from a in db.Cpus
                      where a.ManufacturerCpu.Contains(Filter)
                      select a).ToList();
            b1 = q1;
            dataGridView1.DataSource = b1;

            int i1 = b1.Count();
            for (int a = 0; a < i1; a++)
            {

                string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                addItem(c, "cpu");

            }
        }

        private void cbAMD_OnChange(object sender, EventArgs e)
        {
            if(cbAMD.Checked && cbIntel.Checked)
            {
                poss = 10;
                panel1.Controls.Clear();
                cpu("");
            }else if(cbAMD.Checked && !cbIntel.Checked)
            {
                poss = 10;
                panel1.Controls.Clear();
                cpu("AMD");
            }
            if (cbAMD.Checked && cbIntel.Checked)
            {
                poss = 10;
                panel1.Controls.Clear();
                cpu("");
            }
            else if (!cbAMD.Checked && cbIntel.Checked)
            {
                poss = 10;
                panel1.Controls.Clear();
                cpu("INTEL");
            }
        }

        private void cbIntel_OnChange(object sender, EventArgs e)
        {
            if (cbAMD.Checked && cbIntel.Checked)
            {
                poss = 10;
                panel1.Controls.Clear();
                cpu("");
            }
            else if (!cbAMD.Checked && cbIntel.Checked)
            {
                poss = 10;
                panel1.Controls.Clear();
                cpu("INTEL");
            }
            if (cbAMD.Checked && cbIntel.Checked)
            {
                poss = 10;
                panel1.Controls.Clear();
                cpu("");
            }
            else if (cbAMD.Checked && !cbIntel.Checked)
            {
                poss = 10;
                panel1.Controls.Clear();
                cpu("AMD");
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            poss = 10;
            panel1.Controls.Clear();
            List<Cpu> b1 = new List<Cpu>();
            var q1 = (from a in db.Cpus
                      where a.Cpu_ID.Contains(bunifuMaterialTextbox1.Text)
                      select a).ToList();
            b1 = q1;
            dataGridView1.DataSource = b1;

            int i1 = b1.Count();
            for (int a = 0; a < i1; a++)
            {

                string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                addItem(c, "cpu");

            }
        }
    }
}
