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
    public partial class Part : UserControl

    {
        databeuseDataContext db = new databeuseDataContext();
        public Part()
        {
            InitializeComponent();
        }

        public Part(string Text, string type)
        {
            InitializeComponent();
            if (type == "gpu")
            {
                List<Gpu> b = new List<Gpu>();
                var q = (from a in db.Gpu
                         where a.Gpu_ID == Text
                         select a).ToList();
                b = q;
                dataGridView1.DataSource = b;

                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[9].Value.ToString() + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[10].Value.ToString());
            }
            if (type == "cpu")
            {
                List<Cpu> b = new List<Cpu>();
                var q = (from a in db.Cpu
                         where a.Cpu_ID == Text
                         select a).ToList();
                b = q;
                dataGridView1.DataSource = b;

                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[9].Value.ToString() + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[11].Value.ToString());
            }
            if (type == "memory")
            {
                List<Memory> b = new List<Memory>();
                var q = (from a in db.Memory
                         where a.Memory_ID == Text
                         select a).ToList();
                b = q;
                dataGridView1.DataSource = b;

                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[7].Value.ToString() + "$";
                 pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[8].Value.ToString());
            }
            if (type == "CpuCooler")
            {
                List<CpuCooler> b = new List<CpuCooler>();
                var q = (from a in db.CpuCooler
                         where a.CpuCooler_ID == Text
                         select a).ToList();
                b = q;
                dataGridView1.DataSource = b;

                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[6].Value.ToString() + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[7].Value.ToString());
            }
            if (type == "Case")
            {
                List<Case> b = new List<Case>();
                var q = (from a in db.Case
                         where a.Case_ID == Text
                         select a).ToList();
                b = q;
                dataGridView1.DataSource = b;

                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[5].Value.ToString() + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[6].Value.ToString());
            }
            if (type == "Motherboard")
            {
                List<MotherBoard> b = new List<MotherBoard>();
                var q = (from a in db.MotherBoard
                         where a.MoBo_ID == Text
                         select a).ToList();
                b = q;
                dataGridView1.DataSource = b;

                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[9].Value.ToString() + "$";
                   pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[10].Value.ToString());
            }
            if (type == "PowerSupply")
            {
                List<PowerSupply> b = new List<PowerSupply>();
                var q = (from a in db.PowerSupply
                         where a.PowerSupply_ID == Text
                         select a).ToList();
                b = q;
                dataGridView1.DataSource = b;

                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[6].Value.ToString() + "$";
                   pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[7].Value.ToString());
            }
            if (type == "Storage")
            {
                List<Storage> b = new List<Storage>();
                var q = (from a in db.Storage
                         where a.Storage_ID == Text
                         select a).ToList();
                b = q;
                dataGridView1.DataSource = b;

                lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                lblPrice.Text = dataGridView1.Rows[0].Cells[7].Value.ToString() + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[8].Value.ToString());
            }
        }
    


    private void Part_Load(object sender, EventArgs e)
    {

    }
    }
    }

