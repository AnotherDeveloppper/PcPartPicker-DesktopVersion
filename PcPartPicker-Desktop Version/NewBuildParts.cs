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
    public partial class NewBuildParts : UserControl
    {
        public AddPart part { get; set; }
        private TypePart type;
        public NewBuildParts(TypePart t)
        {
            InitializeComponent();
            this.type = t;
            part = new AddPart();
        }
        
        public void clearsWithFIlter(String Filtere)
        {
            panel1.Controls.Clear();
            poss = 10;


        }
        databeuseDataContext db = new databeuseDataContext();
        int poss = 10;
        public void addItem(string text, string path)
        {
            part = new PcPartPicker_Desktop_Version.AddPart(text, path);
            panel1.Controls.Add(part);
            part.Top = poss;
            poss = (part.Top + part.Height + 5);

        }

        private void AllParts_Load(object sender, EventArgs e)
        {
            switch (type)
            {
                case TypePart.CPU:
                    cpu("");
                    break;
                case TypePart.CASE:
                    Case("");
                    break;
                case TypePart.CPU_COOLER:
                    CpuCooler("");
                    break;
                case TypePart.GPU:
                    gpu("");
                    break;
                case TypePart.MEMORY:
                    Memory("");
                    break;
                case TypePart.MOTHERBOARD:
                    Motherboard("");
                    break;
                case TypePart.POWER_SUPPLY:
                    powersupply("");
                    break;
            }
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
            for (int a = 0; a < i7; a++)
            {

                string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                addItem(c, "Storage");
            }
        }
        public void Case(String Filter)
        {
            List<Case> b4 = new List<Case>();
            var q4 = (from a in db.Cases
                      where a.Case_ID.Contains(Filter)
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

        public void powersupply(String Filter)
        {
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

        private void tbSearch_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            clearsWithFIlter(tbSearch.Text);
        }
    }
}
