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
        databeuseDataContext db = new databeuseDataContext();
        int poss = 10;


        public void addItem(string text, string path)
        {
            Part p = new PcPartPicker_Desktop_Version.Part(text, path);
            panel2.Controls.Add(p);
            p.Top = poss;
            poss = (p.Top + p.Height + 5);

        }

        private void AllParts_Load(object sender, EventArgs e)
        {
            // cpu
            cpu("");
            //mobo
            Motherboard("");
            //cpucooler
            CpuCooler("");
            //memory
            Memory("");
            //gpu
            gpu("");
            //storage
            Storage("");
            //case
            Case("");
            //psu
            powersupply("");       
           
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            clearsWithFIlter(tbSearch.Text);
             
        }

        private void cbCPU_OnChange(object sender, EventArgs e)
        {
            clears();
        }

 
        private void cbRAM_OnChange(object sender, EventArgs e)
        {
            clears();
        }

        private void cbMobo_OnChange(object sender, EventArgs e)
        {
            clears();
        }

        private void bunifuCheckbox4_OnChange(object sender, EventArgs e)
        {
            clears();
        }

        private void bunifuCheckbox6_OnChange(object sender, EventArgs e)
        {
            clears();
        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            clears();
        }

        private void bunifuCheckbox5_OnChange(object sender, EventArgs e)
        {
         
                clears();
          
        }

        private void bunifuCheckbox7_OnChange(object sender, EventArgs e)
        {
          
                clears();
            
        }


        //  ALL HERE
        public void cpu(String Filter)
        {
            List<Cpu> b1 = new List<Cpu>();
            var q1 = (from a in db.Cpus
                      where a.Cpu_ID.Contains(Filter)
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

        public void Storage(String Filter)
        {
                     List<Storage> b7 = new List<Storage>();
        var q7 = (from a in db.Storages
                  where a.Storage_ID.Contains(Filter)
                  select a).ToList();
        b7 = q7;
                dataGridView1.DataSource = b7;

                int i7 = b7.Count();
                for (int a = 0; a<i7; a++)
                {

                    string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                    addItem(c, "Storage");
    }
}
        public void Case (String Filter)
        {
                   List<Case> b4 = new List<Case>();
        var q4 = (from a in db.Cases
                  where a.Case_ID.Contains(Filter)
                  select a).ToList();
        b4 = q4;
                dataGridView1.DataSource = b4;

                int i4 = b4.Count();
                for (int a = 0; a<i4; a++)
                {

                    string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                    addItem(c, "Case");
    }
}

        public void powersupply(String Filter) {
            List<PowerSupply> b6 = new List<PowerSupply>();
            var q6 = (from a in db.PowerSupplies
                      where a.PowerSupply_ID.Contains(Filter)
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
        public void gpu(String Filter)
        {
            List<Gpu> b = new List<Gpu>();
            var q = (from a in db.Gpus
                     where a.Gpu_ID.Contains(Filter)
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
        public void Motherboard(String Filter)
        {
            List<MotherBoard> b5 = new List<MotherBoard>();
            var q5 = (from a in db.MotherBoards
                      where a.MoBo_ID.Contains(Filter)
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
        public void Memory(String Filter)
        {
            List<Memory> b2 = new List<Memory>();
            var q2 = (from a in db.Memories
                      where a.Memory_ID.Contains(Filter)
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
        public void clears()
        {
            panel2.Controls.Clear();
            poss = 10;
            if (cbCPU.Checked) cpu("");
            if (cbRAM.Checked) Memory("");
            if (cbMobo.Checked) Motherboard("");
            if (bunifuCheckbox4.Checked) CpuCooler("");
            if (bunifuCheckbox2.Checked) Storage("");
            if (bunifuCheckbox6.Checked) gpu("");
            if (bunifuCheckbox7.Checked) powersupply("");
            if (bunifuCheckbox5.Checked) Case("");

        }
        public void clearsWithFIlter(String Filtere)
        {
            panel2.Controls.Clear();
            poss = 10;
            if (cbCPU.Checked) cpu(Filtere);
            if (cbRAM.Checked) Memory(Filtere);
            if (cbMobo.Checked) Motherboard(Filtere);
            if (bunifuCheckbox4.Checked) CpuCooler(Filtere);
            if (bunifuCheckbox2.Checked) Storage(Filtere);
            if (bunifuCheckbox6.Checked) gpu(Filtere);
            if (bunifuCheckbox7.Checked) powersupply(Filtere);
            if (bunifuCheckbox5.Checked) Case(Filtere);

        }
    }
}
