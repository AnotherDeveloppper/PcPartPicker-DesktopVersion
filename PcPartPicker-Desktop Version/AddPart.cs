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
                Cpu q = (from a in db.Cpus
                        where a.Cpu_ID == Text
                        select a).FirstOrDefault();


                lbItemName.Text = q.Cpu_ID;
                lblPrice.Text =q.Cpu_Price + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + q.Cpu_Picture);
            }
        }
        public void Case(string Text, string type)
        {
            if (type == "Case")
            {
                List<Case> b = new List<Case>();
                Case q = (from a in db.Cases
                          where a.Case_ID == Text
                         select a).FirstOrDefault();

                lbItemName.Text = q.Case_ID;
                lblPrice.Text = q.Case_Price + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + q.Case_Picture);
            }
        }
        public void cpucooler(string Text, string type)
        {
            if (type == "CpuCooler")
            {
                List<CpuCooler> b = new List<CpuCooler>();
                CpuCooler q = (from a in db.CpuCoolers
                               where a.CpuCooler_ID == Text
                          select a).FirstOrDefault();

                lbItemName.Text = q.CpuCooler_ID;
                lblPrice.Text = q.CpuCooler_Price + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + q.CpuCooler_Picture);
            }
        }
        public void gpu(string Text, string type)
        {
            if (type == "gpu")
            {
                List<Gpu> b = new List<Gpu>();
                Gpu q = (from a in db.Gpus
                         where a.Gpu_ID == Text
                         select a).FirstOrDefault();

                lbItemName.Text = q.Gpu_ID;
                lblPrice.Text = q.Gpu_Price + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + q.Gpu_Picture);
            }
        }
        public void memory(string Text, string type)
        {
            if (type == "memory")
            {
                List<Memory> b = new List<Memory>();
                Memory q = (from a in db.Memories
                         where a.Memory_ID == Text
                         select a).FirstOrDefault();

                lbItemName.Text = q.Memory_ID;
                lblPrice.Text =q.Memory_Price + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + q.Memory_Picture);
            }
        }
        public void motherboard(string Text, string type)
        {
            if (type == "Motherboard")
            {
                List<MotherBoard> b = new List<MotherBoard>();
                MotherBoard q = (from a in db.MotherBoards
                                 where a.MoBo_ID == Text
                                select a).FirstOrDefault();

                lbItemName.Text = q.MoBo_ID;
                lblPrice.Text = q.MoBo_Price + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + q.Mobo_Picture);
            }
        }
        public void powersupply(string Text, string type)
        {
            if (type == "PowerSupply")
            {
                List<PowerSupply> b = new List<PowerSupply>();
                PowerSupply q = (from a in db.PowerSupplies
                                 where a.PowerSupply_ID == Text
                                 select a).FirstOrDefault();

                lbItemName.Text = q.PowerSupply_ID;
                lblPrice.Text = q.Psu_Price + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + q.Psu_Picture);
            }
        }
        public void storage(string Text, string type)
        {
            if (type == "Storage")
            {
                List<Storage> b = new List<Storage>();
                Storage q = (from a in db.Storages
                             where a.Storage_ID == Text
                                 select a).FirstOrDefault();

                lbItemName.Text = q.Storage_ID;
                lblPrice.Text = q.Storage_Price + "$";
                pbItemPic.Image = Image.FromFile(@"images\" + q.Storage_Picture);
            }
        }
    }
}
