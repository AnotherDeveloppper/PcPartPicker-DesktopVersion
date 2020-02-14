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
    public partial class NewBuild : UserControl
    {
        databeuseDataContext db = new databeuseDataContext();
     

        public ADDPART2 msab2 =new ADDPART2();
        public ADDPART2 msab3 = new ADDPART2();
        public ADDPART2 msab4 = new ADDPART2();
        public ADDPART2 msab5 = new ADDPART2();
        public ADDPART2 msab6 = new ADDPART2();
        public ADDPART2 msab7 = new ADDPART2();
        public ADDPART2 msab8 = new ADDPART2();
        public ADDPART2 msab9 = new ADDPART2();
        public NewBuildParts part { get; set; }
        public NewBuild()
        {
            InitializeComponent();
           
            panel2.Controls.Add(msab2);
            msab2.Location = new Point(x:0,y:3);

            panel2.Controls.Add(msab3);
            msab3.Location = new Point(x: 0, y: 63);

            panel2.Controls.Add(msab4);
            msab4.Location = new Point(x: 0, y: 123);

            panel2.Controls.Add(msab5);
            msab5.Location = new Point(x: 0, y: 184);

            panel2.Controls.Add(msab6);
            msab6.Location = new Point(x: 0, y: 244);

            panel2.Controls.Add(msab7);
            msab7.Location = new Point(x: 0, y: 304);

            panel2.Controls.Add(msab8);
            msab8.Location = new Point(x: 0, y: 364);

            panel2.Controls.Add(msab9);
            msab9.Location = new Point(x: 0, y: 424);
        }
        public NewBuild(ADDPART2 c)
        {

            InitializeComponent();
            //cpu
            c = new ADDPART2(Main.cp, "cpu");
            panel2.Controls.Add(c);
            c.Location = new Point(x: 0, y:3);
            //cpucooler
            ADDPART2 cp = new ADDPART2(Main.cpc, "CpuCooler");
            panel2.Controls.Add(cp);
            cp.Location = new Point(x: 0, y: 63);
            //mobo
            ADDPART2 mb = new ADDPART2(Main.mobo, "Motherboard");
            panel2.Controls.Add(mb);
            mb.Location = new Point(x: 0, y: 123);
            //memory
            ADDPART2 ram = new ADDPART2(Main.mem, "memory");
            panel2.Controls.Add(ram);
            ram.Location = new Point(x: 0, y: 184);
            //storage
            ADDPART2 hdd = new ADDPART2(Main.ssd, "Storage");
            panel2.Controls.Add(hdd);
            hdd.Location = new Point(x: 0, y: 244);
            //graphic card
            ADDPART2 video = new ADDPART2(Main.gp, "gpu");
            panel2.Controls.Add(video);
            video.Location = new Point(x: 0, y: 304);
            //case
            ADDPART2 cas = new ADDPART2(Main.chase, "Case");
            panel2.Controls.Add(cas);
            cas.Location = new Point(x: 0, y: 364);
            //psu
            ADDPART2 pspu = new ADDPART2(Main.psp, "PowerSupply");
            panel2.Controls.Add(pspu);
            pspu.Location = new Point(x: 0, y: 424);
        }



        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }



        private void total_power_Click(object sender, EventArgs e)
        {
        }

        private void addPart6_Load(object sender, EventArgs e)
        {

        }

        private void addPart8_Load(object sender, EventArgs e)
        {

        }

        private void NewBuild_Load(object sender, EventArgs e)
        {

        }
    
      
       public void start(ADDPART2 c)
        {
            
            panel2.Controls.Add(c);

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }


    }
}
