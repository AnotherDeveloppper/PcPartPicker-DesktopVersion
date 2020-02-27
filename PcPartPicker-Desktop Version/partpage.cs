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
    public partial class partpage : UserControl
    {
        databeuseDataContext db = new databeuseDataContext();
        public partpage()
        {
            InitializeComponent();
        }
        public partpage(string a)
        {
            InitializeComponent();
            amar(Part.typirino);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void partpage_Load(object sender, EventArgs e)
        {
       
        }

        public  void amar(string b)
        {
            hiderino(b);

            if (b == "Case")
            {
                string id = Part.pID;

                var x = from a in db.Cases where a.Case_ID == id select a;
                dg.DataSource = x;

                this.case_id.Text = dg.Rows[0].Cells[0].Value.ToString();
                this.case_man.Text = dg.Rows[0].Cells[1].Value.ToString();
                this.case_type.Text = dg.Rows[0].Cells[2].Value.ToString();
                this.case_spw.Text = dg.Rows[0].Cells[3].Value.ToString();
                this.case_volume.Text = dg.Rows[0].Cells[4].Value.ToString();
                this.case_price.Text = dg.Rows[0].Cells[5].Value.ToString();
                this.case_pic.Image = Image.FromFile(@"images\" + dg.Rows[0].Cells[6].Value.ToString());
            }

            if (b == "cpu")
            {

                string id = Part.pID;
                var x = from a in db.Cpus where a.Cpu_ID == id select a;
                dg1.DataSource = x;

                this.cpuid.Text = dg1.Rows[0].Cells[0].Value.ToString();
                this.cpuman.Text = dg1.Rows[0].Cells[1].Value.ToString();
                this.cpucore.Text = dg1.Rows[0].Cells[2].Value.ToString();
                this.cputhreads.Text = dg1.Rows[0].Cells[3].Value.ToString();
                this.cpucc.Text = dg1.Rows[0].Cells[4].Value.ToString();
                this.cpubc.Text = dg1.Rows[0].Cells[5].Value.ToString();
                this.cpusocket.Text = dg1.Rows[0].Cells[6].Value.ToString();
                this.cputdp.Text = dg1.Rows[0].Cells[7].Value.ToString();
                this.cpuram.Text = dg1.Rows[0].Cells[8].Value.ToString();
                this.cpuprice.Text = dg1.Rows[0].Cells[9].Value.ToString();
                this.cpuintegrated.Text = dg1.Rows[0].Cells[10].Value.ToString();
                this.cpupic.Image = Image.FromFile(@"images\" + dg1.Rows[0].Cells[11].Value.ToString());
            }
            if (b == "CpuCooler")

            {

                string id = Part.pID;
                var x = from a in db.CpuCoolers where a.CpuCooler_ID == id select a;
                dg2.DataSource = x;

                this.ccid.Text = dg2.Rows[0].Cells[0].Value.ToString();
                this.ccman.Text = dg2.Rows[0].Cells[1].Value.ToString();
                this.ccmod.Text = dg2.Rows[0].Cells[2].Value.ToString();
                this.ccrpm.Text = dg2.Rows[0].Cells[3].Value.ToString();
                this.ccdb.Text = dg2.Rows[0].Cells[4].Value.ToString();
                this.ccwater.Text = dg2.Rows[0].Cells[5].Value.ToString();
                this.ccprice.Text = dg2.Rows[0].Cells[6].Value.ToString();
                this.cpucoolerpic.Image = Image.FromFile(@"images\" + dg2.Rows[0].Cells[7].Value.ToString());
            }
            if (b == "gpu")
            {

                string id = Part.pID;
                var x = from a in db.Gpus where a.Gpu_ID == id select a;
                dg3.DataSource = x;

                this.gid.Text = dg3.Rows[0].Cells[0].Value.ToString();
                this.gman.Text = dg3.Rows[0].Cells[1].Value.ToString();
                this.gchip.Text = dg3.Rows[0].Cells[2].Value.ToString();
                this.gspeed.Text = dg3.Rows[0].Cells[3].Value.ToString();
                this.gtype.Text = dg3.Rows[0].Cells[4].Value.ToString();
                this.gclock.Text = dg3.Rows[0].Cells[5].Value.ToString();
                this.gboost.Text = dg3.Rows[0].Cells[6].Value.ToString();
                this.gsync.Text = dg3.Rows[0].Cells[7].Value.ToString();
                this.gtdp.Text = dg3.Rows[0].Cells[8].Value.ToString();
                this.gprice.Text = dg3.Rows[0].Cells[9].Value.ToString();
                this.gpupic.Image = Image.FromFile(@"images\" + dg3.Rows[0].Cells[10].Value.ToString());
            }
            if (b == "Motherboard")
            {

                string id = Part.pID;
                var x = from a in db.MotherBoards where a.MoBo_ID == id select a;
                dg4.DataSource = x;

                this.mbid.Text = dg4.Rows[0].Cells[0].Value.ToString();
                this.mbman.Text = dg4.Rows[0].Cells[1].Value.ToString();
                this.mbsocket.Text = dg4.Rows[0].Cells[2].Value.ToString();
                this.mbff.Text = dg4.Rows[0].Cells[3].Value.ToString();
                this.mbchip.Text = dg4.Rows[0].Cells[4].Value.ToString();
                this.mbslot.Text = dg4.Rows[0].Cells[5].Value.ToString();
                this.mbmaxram.Text = dg4.Rows[0].Cells[6].Value.ToString();
                this.mbsata.Text = dg4.Rows[0].Cells[7].Value.ToString();
                this.mbm2.Text = dg4.Rows[0].Cells[8].Value.ToString();
                this.mbprice.Text = dg4.Rows[0].Cells[9].Value.ToString();
                this.mobopic.Image = Image.FromFile(@"images\" + dg4.Rows[0].Cells[10].Value.ToString());
            }

            if (b == "memory")
            {

                string id = Part.pID;
                var x = from a in db.Memories where a.Memory_ID == id select a;
                dg5.DataSource = x;

                this.memid.Text = dg5.Rows[0].Cells[0].Value.ToString();
                this.memman.Text = dg5.Rows[0].Cells[1].Value.ToString();
                this.memsize.Text = dg5.Rows[0].Cells[2].Value.ToString();
                this.memspeed.Text = dg5.Rows[0].Cells[3].Value.ToString();
                this.memslots.Text = dg5.Rows[0].Cells[4].Value.ToString();
                this.memvol.Text = dg5.Rows[0].Cells[5].Value.ToString();
                this.memcas.Text = dg5.Rows[0].Cells[6].Value.ToString();
                this.memprice.Text = dg5.Rows[0].Cells[7].Value.ToString();
                this.MemoryPic.Image = Image.FromFile(@"images\" + dg5.Rows[0].Cells[8].Value.ToString());
            }
            if (b == "Storage")
            {

                string id = Part.pID;
                var x = from a in db.Storages where a.Storage_ID == id select a;
                dg6.DataSource = x;

                this.sid.Text = dg6.Rows[0].Cells[0].Value.ToString();
                this.sman.Text = dg6.Rows[0].Cells[1].Value.ToString();
                this.scap.Text = dg6.Rows[0].Cells[2].Value.ToString();
                this.stype.Text = dg6.Rows[0].Cells[3].Value.ToString();
                this.sff.Text = dg6.Rows[0].Cells[4].Value.ToString();
                this.sinter.Text = dg6.Rows[0].Cells[5].Value.ToString();
                this.snvme.Text = dg6.Rows[0].Cells[6].Value.ToString();
                this.sprice.Text = dg6.Rows[0].Cells[7].Value.ToString();
                this.Storagepic.Image = Image.FromFile(@"images\" + dg6.Rows[0].Cells[8].Value.ToString());
            }
            if (b == "PowerSupply")
            {

                string id = Part.pID;
                var x = from a in db.PowerSupplies where a.PowerSupply_ID == id select a;
                dg7.DataSource = x;

                this.psuid.Text = dg7.Rows[0].Cells[0].Value.ToString();
                this.psuman.Text = dg7.Rows[0].Cells[1].Value.ToString();
                this.psuff.Text = dg7.Rows[0].Cells[2].Value.ToString();
                this.psuer.Text = dg7.Rows[0].Cells[3].Value.ToString();
                this.psuwatt.Text = dg7.Rows[0].Cells[4].Value.ToString();
                this.psumod.Text = dg7.Rows[0].Cells[5].Value.ToString();
                this.psuprice.Text = dg7.Rows[0].Cells[6].Value.ToString();
                this.PsuPic.Image = Image.FromFile(@"images\" + dg7.Rows[0].Cells[7].Value.ToString());
            }

        }
        public void hiderino(string a)
        {
            //MessageBox.Show("" + a);
            if (a == "Case") { casepanel.Show(); casepanel.BringToFront(); } else { casepanel.Hide(); }
            if (a == "cpu") { cpupanel.Show(); cpupanel.BringToFront(); } else { cpupanel.Hide(); }
            if (a == "CpuCooler") { panelcpucooler.Show(); cpupanel.BringToFront(); } else { panelcpucooler.Hide(); }
            if (a == "gpu") { panelGpu.Show(); cpupanel.BringToFront(); } else { panelGpu.Hide(); }
            if (a == "memory") { panelMemory.Show(); cpupanel.BringToFront(); } else { panelMemory.Hide(); }
            if (a == "Motherboard") { panelmobo.Show(); cpupanel.BringToFront(); } else { panelmobo.Hide(); }
            if (a == "PowerSupply") { psupanel.Show(); cpupanel.BringToFront(); } else { psupanel.Hide(); }
            if (a == "Storage") { panelstorage.Show(); cpupanel.BringToFront(); } else { panelstorage.Hide(); }

        }

           

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelGpu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void psupanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
