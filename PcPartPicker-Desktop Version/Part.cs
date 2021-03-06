﻿using System;
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
        public static string pID;
        public static string typirino="";
        public Part()
        {
            InitializeComponent();
        }

        public Part(string Text)
        {
            InitializeComponent();
            lbItemName.Text = Text;
        }

        public Part(string Text, string type)
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

                label1.Text = "cpu";
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
                label1.Text = "Case";
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
                label1.Text = "CpuCooler";
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
                label1.Text = "gpu";
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
                label1.Text = "memory";
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
                label1.Text = "Motherboard";
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

        //UC CLICK 
        public new event EventHandler Click
        {
            add
            {
                base.Click += value;
                foreach (Control control in Controls)
                {
                    control.Click += value;
                }
            }
            remove
            {
                base.Click -= value;
                foreach (Control control in Controls)
                {
                    control.Click -= value;
                }
            }
        }

        public void powersupply(string Text, string type)
        {
            if (type == "PowerSupply")
            {
                label1.Text = "PowerSupply";
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
                label1.Text = "Storage";
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

        private void Part_Load(object sender, EventArgs e)
        {

        }

        private void Part_Click(object sender, EventArgs e)
        {
            pID = this.lbItemName.Text;
            typirino = label1.Text;
            
            Main.main.partpageshow();
        }
    }
    }

