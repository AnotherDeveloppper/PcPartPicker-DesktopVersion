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
              this.label2.Text= dgbuild.Rows[0].Cells[10].Value.ToString();
              int userid = Convert.ToInt32(this.label2.Text);
              //user 
              var us = from a in db.USERs where a.USER_ID == userid select a;
              dguser.DataSource = us;
              this.username.Text= dguser.Rows[0].Cells[1].Value.ToString();
              this.userpic.Image = Image.FromFile(@"images\" + dguser.Rows[0].Cells[8].Value.ToString());

              // listprebuild[i].pic = Image.FromFile(@"images\" + dg.Rows[i].Cells[14].Value.ToString());
              
            
        }
    }
    
}
