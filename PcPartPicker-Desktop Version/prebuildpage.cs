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
    public partial class prebuildpage : UserControl
    {
        databeuseDataContext db = new databeuseDataContext();
        public prebuildpage()
        {
            InitializeComponent();
        }

        private void prebuildpage_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(prebuild.sID);
              //BUILD INFO + user info //
              //BUILD
              var bd = from a in db.BUILDs where a.Build_ID == id select a ;
              dgbuild.DataSource = bd;
              this.buildname.Text = dgbuild.Rows[0].Cells[1].Value.ToString();
              this.cpuname.Text = dgbuild.Rows[0].Cells[7].Value.ToString();
              this.moboname.Text = dgbuild.Rows[0].Cells[8].Value.ToString();
              this.memoryname.Text = dgbuild.Rows[0].Cells[9].Value.ToString();
              this.storagename.Text = dgbuild.Rows[0].Cells[6].Value.ToString();
              this.gpuname.Text = dgbuild.Rows[0].Cells[5].Value.ToString();
              this.casename.Text = dgbuild.Rows[0].Cells[2].Value.ToString();
              this.psuname.Text = dgbuild.Rows[0].Cells[3].Value.ToString();
              this.cpucoolername.Text = dgbuild.Rows[0].Cells[4].Value.ToString();
            this.label2.Text= dgbuild.Rows[0].Cells[10].Value.ToString();
                this.buildpic.Image = Image.FromFile(@"images\" + dgbuild.Rows[0].Cells[14].Value.ToString());
            int userid = Convert.ToInt32(this.label2.Text);
              //user 
              var us = from a in db.USERs where a.USER_ID == userid select a;
              dguser.DataSource = us;
              this.username.Text= dguser.Rows[0].Cells[1].Value.ToString();
              this.userpic.Image = Image.FromFile(@"images\" + dguser.Rows[0].Cells[8].Value.ToString());
            // cpu info
            var cp = from a in db.Cpus where a.Cpu_ID == cpuname.Text select a;
            dgcpu.DataSource = cp;
               this.cpuprice.Text= dgcpu.Rows[0].Cells[9].Value.ToString();
            this.cpupic.Image = Image.FromFile(@"images\" + dgcpu.Rows[0].Cells[11].Value.ToString());
            // motherboard info 
            var mb = from a in db.MotherBoards where a.MoBo_ID == moboname.Text select a;
            dgmobo.DataSource = mb;
            this.moboprice.Text = dgmobo.Rows[0].Cells[9].Value.ToString();
            this.mobopic.Image = Image.FromFile(@"images\" + dgmobo.Rows[0].Cells[10].Value.ToString());
            // ram info 
            var rm = from a in db.Memories where a.Memory_ID == memoryname.Text select a;
            dgram.DataSource = rm;
            this.memoryprice.Text = dgram.Rows[0].Cells[7].Value.ToString();
            this.memorypic.Image = Image.FromFile(@"images\" + dgram.Rows[0].Cells[8].Value.ToString());
            // storage info
            var st = from a in db.Storages where a.Storage_ID == storagename.Text select a;
            dgstorage.DataSource = st;
            this.storageprice.Text = dgstorage.Rows[0].Cells[7].Value.ToString();
            this.storagepic.Image = Image.FromFile(@"images\" + dgstorage.Rows[0].Cells[8].Value.ToString());
            // gpu info 
            var gp = from a in db.Gpus where a.Gpu_ID == gpuname.Text select a;
            dggpu.DataSource = gp;
            this.gpuprice.Text = dggpu.Rows[0].Cells[9].Value.ToString();
            this.gpupic.Image = Image.FromFile(@"images\" + dggpu.Rows[0].Cells[10].Value.ToString());
            // case info 
            var cs = from a in db.Cases where a.Case_ID == casename.Text select a;
            dgcase.DataSource = cs;
            this.caseprice.Text = dgcase.Rows[0].Cells[5].Value.ToString();
            this.casepic.Image = Image.FromFile(@"images\" + dgcase.Rows[0].Cells[6].Value.ToString());
            // PSU info 
            var ps = from a in db.PowerSupplies where a.PowerSupply_ID == psuname.Text select a;
            dgpsu.DataSource = ps;
            this.psuprice.Text = dgpsu.Rows[0].Cells[6].Value.ToString();
            this.psupic.Image = Image.FromFile(@"images\" + dgpsu.Rows[0].Cells[7].Value.ToString());
            // cpu cooler info 
            var cpp = from a in db.CpuCoolers where a.CpuCooler_ID == cpucoolername.Text select a;
            dgcpucooler.DataSource = cpp;
            this.cpucoolerprice.Text = dgcpucooler.Rows[0].Cells[6].Value.ToString();
            this.cpucoolerpic.Image = Image.FromFile(@"images\" + dgcpucooler.Rows[0].Cells[7].Value.ToString());





        }
    }
    
}
