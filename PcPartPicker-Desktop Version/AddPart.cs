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

        string tipe;
        databeuseDataContext db = new databeuseDataContext();
        public AddPart()
        {
            InitializeComponent();
        }
        public AddPart(string Text, string type)
        {
            InitializeComponent();
            tipe = type;
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
                var q = from a in db.Cpus
                        where a.Cpu_ID == Text
                        select a;
                dataGridView1.DataSource = q.ToList();

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
                var q = (from a in db.Cases
                         where a.Case_ID == Text
                         select a).ToList();
                b = q;
                dataGridView1.DataSource = b;

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
                var q = (from a in db.CpuCoolers
                         where a.CpuCooler_ID == Text
                         select a).ToList();
                b = q;
                dataGridView1.DataSource = b;

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
                var q = (from a in db.Gpus
                         where a.Gpu_ID == Text
                         select a).ToList();
                b = q;
                dataGridView1.DataSource = b;

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
                var q = (from a in db.Memories
                         where a.Memory_ID == Text
                         select a).ToList();
                b = q;
                dataGridView1.DataSource = b;

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
                var q = (from a in db.MotherBoards
                         where a.MoBo_ID == Text
                         select a).ToList();
                b = q;
                dataGridView1.DataSource = b;

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
                var q = (from a in db.PowerSupplies
                         where a.PowerSupply_ID == Text
                         select a).ToList();
                b = q;
                dataGridView1.DataSource = b;

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
                var q = (from a in db.Storages
                         where a.Storage_ID == Text
                         select a).ToList();
                b = q;
                dataGridView1.DataSource = b;

                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[7].Value.ToString() + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[8].Value.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void pbItemPic_Click(object sender, EventArgs e)
        {

        }

        private void lbItemName_Click(object sender, EventArgs e)
        {

        }

        private void AddPart_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (tipe == "cpu")
            {
                Main.cp = dataGridView1.Rows[0].Cells[0].Value.ToString();
                // calll cpucooler
                Main.WATTAGE +=Convert.ToInt32( dataGridView1.Rows[0].Cells[7].Value.ToString());
                Main.PRICE += Convert.ToDouble(dataGridView1.Rows[0].Cells[9].Value.ToString());
                Main.main.cpucoolerCheck();
                

            }
            if (tipe == "CpuCooler")
            {
                Main.cpc = dataGridView1.Rows[0].Cells[0].Value.ToString();
                Main.PRICE += Convert.ToDouble(dataGridView1.Rows[0].Cells[6].Value.ToString());
                // calll cpumobo 
                Main.main.moboCheck();
            }
            if (tipe == "Motherboard")
            {
                Main.mobo = dataGridView1.Rows[0].Cells[0].Value.ToString();
                Main.PRICE += Convert.ToDouble(dataGridView1.Rows[0].Cells[9].Value.ToString());
                // calll ram
                Main.main.ramCheck();
            }
     
            if (tipe == "memory")
            {
                Main.mem = dataGridView1.Rows[0].Cells[0].Value.ToString();
                Main.PRICE += Convert.ToDouble(dataGridView1.Rows[0].Cells[7].Value.ToString());
                // calll storage
                //  MessageBox.Show("" + dataGridView1.Rows[0].Cells[5].Value.ToString());
                //   Main.WATTAGE += Convert.ToInt32(dataGridView1.Rows[0].Cells[5].Value.ToString());
                Main.main.storageCheck();

            }
          
            if (tipe == "Storage")
            {
                Main.ssd = dataGridView1.Rows[0].Cells[0].Value.ToString();
                Main.PRICE += Convert.ToDouble(dataGridView1.Rows[0].Cells[7].Value.ToString());
                // calll gpu
                Main.main.gpuCheck();
            }
            if (tipe == "gpu")
            {
                Main.gp = dataGridView1.Rows[0].Cells[0].Value.ToString();
                // calll psu
                Main.WATTAGE += Convert.ToInt32(dataGridView1.Rows[0].Cells[8].Value.ToString());
                Main.PRICE += Convert.ToDouble(dataGridView1.Rows[0].Cells[9].Value.ToString());
             
                Main.main.psuCheck();
            }
            if (tipe == "PowerSupply")
            {
                Main.psp = dataGridView1.Rows[0].Cells[0].Value.ToString();
                Main.PRICE += Convert.ToDouble(dataGridView1.Rows[0].Cells[6].Value.ToString());
                // calll case

                Main.main.caseCheck();
            }
          
            if (tipe == "Case")
            {
                Main.chase = dataGridView1.Rows[0].Cells[0].Value.ToString();
                Main.PRICE += Convert.ToDouble(dataGridView1.Rows[0].Cells[5].Value.ToString());
                // calll all page

                Main.main.FULLBUILD();
            }


        }
    }
}
