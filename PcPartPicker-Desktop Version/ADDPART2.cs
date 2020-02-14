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
    public partial class ADDPART2 : UserControl
    {
        private TypePart type1;
        databeuseDataContext db = new databeuseDataContext();
        public ADDPART2()
        {
            InitializeComponent();
        }
        public ADDPART2(string Text)
        {
            InitializeComponent();
            lbItemName.Text = Text;
        }

        public ADDPART2(string Text, string type)
        {
            InitializeComponent();
            if (type == "cpu") {
                var q = (from a in db.Cpu
                    where a.Cpu_ID.Contains(Text)
                    select a).ToList();
          dataGridView1.DataSource = q;
         lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
         lblPrice.Text = dataGridView1.Rows[0].Cells[9].Value.ToString();
         pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[11].Value.ToString());
            }
            if (type == "Case")
            {
                List<Case> b = new List<Case>();
                var q = (from a in db.Case
                         where a.Case_ID.Contains(Text)
                         select a).ToList();
                dataGridView1.DataSource = q;
                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[5].Value.ToString() + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[6].Value.ToString());
            }
            if (type == "CpuCooler")
            {
                List<CpuCooler> b = new List<CpuCooler>();
                var q = (from a in db.CpuCooler
                         where a.CpuCooler_ID.Contains(Text)
                         select a).ToList();
                dataGridView1.DataSource = q;
                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[6].Value.ToString() + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[7].Value.ToString());
            }
            if (type == "gpu")
            {
                List<Gpu> b = new List<Gpu>();
                var q = (from a in db.Gpu
                         where a.Gpu_ID.Contains(Text)
                         select a).ToList();
                dataGridView1.DataSource = q;
                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[9].Value.ToString() + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[10].Value.ToString());
            }
            if (type == "memory")
            {
                List<Memory> b = new List<Memory>();
                var q = (from a in db.Memory
                         where a.Memory_ID.Contains(Text)
                         select a).ToList();
                dataGridView1.DataSource = q;
                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[7].Value.ToString() + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[8].Value.ToString());
            }
            if (type == "Motherboard")
            {
                List<MotherBoard> b = new List<MotherBoard>();
                var q = (from a in db.MotherBoard
                         where a.MoBo_ID.Contains(Text)
                         select a).ToList();
                dataGridView1.DataSource = q;
                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[9].Value.ToString() + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[10].Value.ToString());
            }
            if (type == "PowerSupply")
            {
                List<PowerSupply> b = new List<PowerSupply>();
                var q = (from a in db.PowerSupply
                         where a.PowerSupply_ID.Contains(Text)
                         select a).ToList();
                dataGridView1.DataSource = q;
                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[6].Value.ToString() + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[7].Value.ToString());
            }
            if (type == "Storage")
            {
                List<Storage> b = new List<Storage>();
                var q = (from a in db.Storage
                         where a.Storage_ID.Contains(Text)
                         select a).ToList();
                dataGridView1.DataSource = q;
                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
                pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[8].Value.ToString());
            }

        }


        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            switch (type1)
            {
                case TypePart.CPU:
                    Main.main.callparts(TypePart.CPU);
                    break;
                case TypePart.CASE:
                    Main.main.callparts(TypePart.CASE);
                    break;
                case TypePart.CPU_COOLER:
                    Main.main.callparts(TypePart.CPU_COOLER);
                    break;
                case TypePart.GPU:
                    Main.main.callparts(TypePart.GPU);
                    break;
                case TypePart.MEMORY:
                    Main.main.callparts(TypePart.MEMORY);
                    break;
                case TypePart.MOTHERBOARD:
                    Main.main.callparts(TypePart.MOTHERBOARD);
                    break;
                case TypePart.POWER_SUPPLY:
                    Main.main.callparts(TypePart.POWER_SUPPLY);
                    break;
            }
           
           

        }

        private void ADDPART2_Load(object sender, EventArgs e)
        {
           
        }
    }
}
