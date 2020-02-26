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
    public partial class urbuilds : UserControl
    {
        int min, max;
        public static Main main;


        databeuseDataContext db = new databeuseDataContext();
        public urbuilds()
        {
            InitializeComponent();
        }

        private void builds()
        {

            var x = from a in db.BUILDs select a; 

            string xid = Main.main.uid;
            if(xid == "1" || xid == "2" || xid == "3") {
                x = from a in db.BUILDs  select a;
            }
            else
            {
                x = from a in db.BUILDs where a.USER_ID == Convert.ToInt32(xid) select a;
            }

           
            dg.DataSource = x;

            urbuild[] listurbuild = new urbuild[dg.Rows.Count - 1];

            for (int i = 0; i < listurbuild.Length; i++)
            {
                listurbuild[i] = new urbuild();
                listurbuild[i].id = dg.Rows[i].Cells[0].Value.ToString();
                listurbuild[i].builder = dg.Rows[i].Cells[7].Value.ToString();
                listurbuild[i].title = dg.Rows[i].Cells[1].Value.ToString();
                listurbuild[i].price = dg.Rows[i].Cells[11].Value.ToString() + " $";
                listurbuild[i].gpu = dg.Rows[i].Cells[5].Value.ToString();
                listurbuild[i].cpu = dg.Rows[i].Cells[7].Value.ToString();
                listurbuild[i].pic = Image.FromFile(@"images\" + dg.Rows[i].Cells[14].Value.ToString());
                tableLayoutPanel1.Controls.Add(listurbuild[i]);

            }
            
        }

        private void minP_OnValueChanged(object sender, EventArgs e)
        {
            btn_ok.Visible = true;
        }

        private void maxP_OnValueChanged(object sender, EventArgs e)
        {
            btn_ok.Visible = true;
        }

        private void urbuilds_Load_1(object sender, EventArgs e)
        {
            builds();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            min = Convert.ToInt32(minP.Text);
            max = Convert.ToInt32(maxP.Text);
            MessageBox.Show(min + " " + max);
        }
    }
}
