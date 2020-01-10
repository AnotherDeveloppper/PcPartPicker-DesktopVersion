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
        databeuseDataContext db = new databeuseDataContext();
        public AllParts()
        {
            InitializeComponent();
        }

        int poss = 10;
     
        public void addItem(string text,string path)
        {
            Part p = new PcPartPicker_Desktop_Version.Part(text,path);
            panel2.Controls.Add(p);
            p.Top = poss;
            poss = (p.Top + p.Height + 5);

        }
        public void empty(){
            poss = 0;
            }

        private void AllParts_Load(object sender, EventArgs e)
        {
            
          
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
        }

        private void cbCPU_OnChange(object sender, EventArgs e)
        {
            if (cbCPU.Checked)
            {

                List<Cpu> b1 = new List<Cpu>();
                var q1 = (from a in db.Cpu
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
            if (!cbCPU.Checked)
            {

            }
        }

        private void cbRAM_OnChange(object sender, EventArgs e)
        {
            if (cbRAM.Checked)
            {
                List<Memory> b2 = new List<Memory>();
                var q2 = (from a in db.Memory
                          select a).ToList();
                b2 = q2;
                dataGridView1.DataSource = b2;

                int i2 = b2.Count();
                for (int a = 0; a < i2; a++)
                {

                    string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                    addItem(c, "memory");
                }

            }
        }

        private void cbMobo_OnChange(object sender, EventArgs e)
        {
            if (cbMobo.Checked)
            {
                List<MotherBoard> b5 = new List<MotherBoard>();
                var q5 = (from a in db.MotherBoard
                          select a).ToList();
                b5 = q5;
                dataGridView1.DataSource = b5;

                int i5 = b5.Count();
                for (int a = 0; a < i5; a++)
                {

                    string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                    addItem(c, "Motherboard");
                }
            }
        }

        private void bunifuCheckbox4_OnChange(object sender, EventArgs e)
        {
            if (cbcpucooler.Checked)
            {
                List<CpuCooler> b3 = new List<CpuCooler>();
                var q3 = (from a in db.CpuCooler
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
        }

        private void cbst_OnChange(object sender, EventArgs e)
        {
            if (cbst.Checked)
            {
                List<Storage> b7 = new List<Storage>();
                var q7 = (from a in db.Storage
                          select a).ToList();
                b7 = q7;
                dataGridView1.DataSource = b7;

                int i7 = b7.Count();
                for (int a = 0; a < i7; a++)
                {

                    string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                    addItem(c, "Storage");
                }
            }
        }

        private void cbggpp_OnChange(object sender, EventArgs e)
        {
            if (cbggpp.Checked)
            {
                List<Gpu> b = new List<Gpu>();
                var q = (from a in db.Gpu
                         select a).ToList();
                b = q;
                dataGridView1.DataSource = b;

                int i = b.Count();
                for (int a = 0; a < i; a++)
                {

                    string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                    addItem(c, "gpu");
                }

            }
        }

        private void cbpssu_OnChange(object sender, EventArgs e)
        {
                if (cbpssu.Checked)
                {
                List<PowerSupply> b6 = new List<PowerSupply>();
                var q6 = (from a in db.PowerSupply
                          select a).ToList();
                b6 = q6;
                dataGridView1.DataSource = b6;

                int i6 = b6.Count();
                for (int a = 0; a < i6; a++)
                {

                    string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                    addItem(c, "PowerSupply");
                }
            }
        }

        private void cbcASSE_OnChange(object sender, EventArgs e)
        {
            if (cbcASSE.Checked)
            {
                List<Case> b4 = new List<Case>();
                var q4 = (from a in db.Case
                          select a).ToList();
                b4 = q4;
                dataGridView1.DataSource = b4;

                int i4 = b4.Count();
                for (int a = 0; a < i4; a++)
                {

                    string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                    addItem(c, "Case");
                }
            }
        }
    }
}
