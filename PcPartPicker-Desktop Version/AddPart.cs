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
    public partial class AddPart : UserControl
    {

        public static ADDPART2 msab;
        string a;
        private TypePart type1;
        databeuseDataContext db = new databeuseDataContext();
        public AddPart()
        {
            InitializeComponent();
        }
    

        public AddPart(string Text)
        {
            InitializeComponent();
            lbItemName.Text = Text;
        }

        public AddPart(string Text, string type)
        {
            InitializeComponent();
            gpu(Text, type);
            cpu(Text, type);
            memory(Text, type);
            cpucooler(Text, type);
            Case(Text, type);
            motherboard(Text, type);
            powersupply(Text, type);
            storage(Text, type);

        }

        /// HERE WE GOT THE THINGS
        public void cpu(string Text, string type)
        {
            if (type == "cpu")
            {
                var q = from a in db.Cpu
                        where a.Cpu_ID.Contains(Text)
                        select a; 
                dataGridView1.DataSource = q.ToList();
                a = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[9].Value.ToString() + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[11].Value.ToString());
            }
        }
        public void Case(string Text, string type)
        {
            if (type == "Case")
            {
                List<Case> b = new List<Case>();
                var q = from a in db.Case
                         where a.Case_ID == Text
                         select a;
                dataGridView1.DataSource = q.ToList();
                a = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[5].Value.ToString() + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[6].Value.ToString());
            }
        }
        public void cpucooler(string Text, string type)
        {
            if (type == "CpuCooler")
            {
                List<CpuCooler> b = new List<CpuCooler>();
                var q = from a in db.CpuCooler
                         where a.CpuCooler_ID == Text
                         select a;
                dataGridView1.DataSource = q.ToList();
                a = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[6].Value.ToString() + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[7].Value.ToString());
            }
        }
        public void gpu(string Text, string type)
        {
            if (type == "gpu")
            {
                List<Gpu> b = new List<Gpu>();
                var q = from a in db.Gpu
                         where a.Gpu_ID == Text
                         select a;
                dataGridView1.DataSource = q.ToList();
                a = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[9].Value.ToString() + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[10].Value.ToString());
            }
        }
        public void memory(string Text, string type)
        {
            if (type == "memory")
            {
                List<Memory> b = new List<Memory>();
                var q = from a in db.Memory
                         where a.Memory_ID == Text
                         select a;
                dataGridView1.DataSource = q.ToList();
                a = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[7].Value.ToString() + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[8].Value.ToString());
            }
        }
        public void motherboard(string Text, string type)
        {
            if (type == "Motherboard")
            {
                List<MotherBoard> b = new List<MotherBoard>();
                var q =from a in db.MotherBoard
                         where a.MoBo_ID == Text
                         select a;
                dataGridView1.DataSource = q.ToList();
                a = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[9].Value.ToString() + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[10].Value.ToString());
            }
        }
        public void powersupply(string Text, string type)
        {
            if (type == "PowerSupply")
            {
                List<PowerSupply> b = new List<PowerSupply>();
                var q = from a in db.PowerSupply
                         where a.PowerSupply_ID == Text
                         select a;
                dataGridView1.DataSource = q.ToList();
                a = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[6].Value.ToString() + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[7].Value.ToString());
            }
        }
        public void storage(string Text, string type)
        {
            if (type == "Storage")
            {
                List<Storage> b = new List<Storage>();
                var q = from a in db.Storage
                        where a.Storage_ID == Text
                        select a;
                dataGridView1.DataSource = q.ToList();
                a = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
                pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[8].Value.ToString());
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            switch (type1)
            {
                case TypePart.CPU:
                    Main.cp = a;
                    NewBuild c = new NewBuild(msab);
                    Main.main.hideParts(c);
                    break;
                case TypePart.CASE:
                    Main.chase = a;
                    NewBuild ca = new NewBuild(msab);
                    Main.main.hideParts(ca);
                    break;
                case TypePart.CPU_COOLER:
                    Main.cpc = a;
                    NewBuild cc = new NewBuild(msab);
                    Main.main.hideParts(cc);
                    break;
                case TypePart.GPU:
                    Main.gp = a;
                    NewBuild g = new NewBuild(msab);
                    Main.main.hideParts(g);
                    break;
                case TypePart.MEMORY:
                    Main.mem = a;
                    NewBuild me = new NewBuild(msab);
                    Main.main.hideParts(me);
                    break;
                case TypePart.MOTHERBOARD:
                    Main.mobo = a;
                    NewBuild mob = new NewBuild(msab);
                    Main.main.hideParts(mob);
                    break;
                case TypePart.POWER_SUPPLY:
                    Main.psp = a;
                    NewBuild ps = new NewBuild(msab);
                    Main.main.hideParts(ps);
                    break;
            }

          
        }
      
        private void AddPart_Load(object sender, EventArgs e)
        {  
        }
    }
}