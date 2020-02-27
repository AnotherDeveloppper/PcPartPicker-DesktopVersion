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

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

            clears();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            min = Convert.ToInt32(minP.Text);
            max = Convert.ToInt32(maxP.Text);
        }

        public void clears()
        {
            tableLayoutPanel1.Controls.Clear();
            min = 0;
            max = 0;
            if (minP.Text != "" && maxP.Text != "")
            {
                min = Convert.ToInt32(minP.Text);
                max = Convert.ToInt32(maxP.Text);
            }
            string a = Searchtxt.Text;
            if (bunifuCheckbox1.Checked && bunifuCheckbox3.Checked) builds(min, max, a, "INTEL", "G-Sync");
                if (bunifuCheckbox1.Checked && bunifuCheckbox4.Checked) builds(min, max, a, "INTEL", "Freesync");
                if (bunifuCheckbox2.Checked && bunifuCheckbox3.Checked) builds(min, max, a, "AMD", "G-Sync");
                if (bunifuCheckbox2.Checked && bunifuCheckbox4.Checked) builds(min, max, a, "AMD", "Freesync");
            
        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {

            clears();
        }

        private void bunifuCheckbox4_OnChange(object sender, EventArgs e)
        {

            clears();
        }

        private void bunifuCheckbox3_OnChange(object sender, EventArgs e)
        {

            clears();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            clears();
        }

        private void btn_ok_Click_1(object sender, EventArgs e)
        {
            clears();
        }

        private void builds(int mi, int Ma, string filter, string cpu, string gpu)
        {

            string xid = Main.main.uid;
            var x = from a in db.BUILDs select a;
            if (Ma != 0)
            {
                 x = from a in db.BUILDs
                        join b in db.Cpus on a.Cpu_ID equals b.Cpu_ID
                        join c in db.Gpus on a.Gpu_ID equals c.Gpu_ID
                        where

                         (a.USER_ID == Convert.ToInt32(xid) && (a.Total_Price <= Ma) && (a.Total_Price >= mi))
                        && a.Build_Name.Contains(filter) && b.ManufacturerCpu.Contains(cpu)
                        && c.Frame_Sync.Contains(gpu)

                        select a;
            }else
            {
                x = from a in db.BUILDs
                    join b in db.Cpus on a.Cpu_ID equals b.Cpu_ID
                    join c in db.Gpus on a.Gpu_ID equals c.Gpu_ID
                    where

                     (a.USER_ID == Convert.ToInt32(xid) &&  (a.Total_Price >= mi))
                    && a.Build_Name.Contains(filter) && b.ManufacturerCpu.Contains(cpu)
                    && c.Frame_Sync.Contains(gpu)

                    select a;

            }
            dg.DataSource = x;

            urbuild[] listprebuild = new urbuild[dg.Rows.Count - 1];

            for (int i = 0; i < listprebuild.Length; i++)
            {
                listprebuild[i] = new urbuild();
                listprebuild[i].id = dg.Rows[i].Cells[0].Value.ToString();
                listprebuild[i].builder = dg.Rows[i].Cells[7].Value.ToString();
                listprebuild[i].title = dg.Rows[i].Cells[1].Value.ToString();
                listprebuild[i].price = dg.Rows[i].Cells[11].Value.ToString() + " $";
                listprebuild[i].gpu = dg.Rows[i].Cells[5].Value.ToString();
                listprebuild[i].cpu = dg.Rows[i].Cells[7].Value.ToString();
                listprebuild[i].pic = Image.FromFile(@"images\" + dg.Rows[i].Cells[14].Value.ToString());
                tableLayoutPanel1.Controls.Add(listprebuild[i]);

            }

        }
    }
}
