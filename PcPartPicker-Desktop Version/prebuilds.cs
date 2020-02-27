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
    public partial class prebuilds : UserControl
    {
        int min, max;

        databeuseDataContext db = new databeuseDataContext();
        public prebuilds()
        {
            InitializeComponent();
        }

        private void prebuilds_Load(object sender, EventArgs e)
        {
            builds();

            if (Main.main.uid == "1" || Main.main.uid == "2" || Main.main.uid == "3")
            {
                addbtn.Visible = true;
            }

        }

        private void builds ()
        {
            var x = from a in db.BUILDs  where (a.USER_ID==1 || a.USER_ID==2 || a.USER_ID==3) select a;
            dg.DataSource = x;

            prebuild[] listprebuild = new prebuild[dg.Rows.Count-1];

            for (int i=0; i < listprebuild.Length; i++)
            {
                listprebuild[i] = new prebuild();
                listprebuild[i].id = dg.Rows[i].Cells[0].Value.ToString();
                listprebuild[i].builder= dg.Rows[i].Cells[7].Value.ToString();
                listprebuild[i].title = dg.Rows[i].Cells[1].Value.ToString();
                listprebuild[i].price = dg.Rows[i].Cells[11].Value.ToString()+" $";
                listprebuild[i].gpu = dg.Rows[i].Cells[5].Value.ToString();
                listprebuild[i].cpu = dg.Rows[i].Cells[7].Value.ToString();
                listprebuild[i].pic = Image.FromFile(@"images\" + dg.Rows[i].Cells[14].Value.ToString());
                tableLayoutPanel1.Controls.Add(listprebuild[i]);

            }

        }
        private void builds(int mi,int Ma)
        {
            var x = from a in db.BUILDs where ((a.USER_ID == 1 || a.USER_ID == 2 || a.USER_ID == 3) && (a.Total_Price <=  Ma ) && (a.Total_Price >= mi)) select a;
            dg.DataSource = x;

            prebuild[] listprebuild = new prebuild[dg.Rows.Count - 1];

            for (int i = 0; i < listprebuild.Length; i++)
            {
                listprebuild[i] = new prebuild();
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

        private void builds(int mi, int Ma , string filter, string cpu, string gpu)
        {
            var x = from a in db.BUILDs 
                     join b in db.Cpus on a.Cpu_ID equals b.Cpu_ID
                     join c in db.Gpus on a.Gpu_ID equals c.Gpu_ID
                    where
                   ((a.USER_ID == 1 || a.USER_ID == 2 || a.USER_ID == 3) && (a.Total_Price <= Ma) && (a.Total_Price >= mi))
                    && a.Build_Name.Contains(filter) && b.ManufacturerCpu.Contains(cpu)
                    && c.Frame_Sync.Contains(gpu)

                    select a;
            dg.DataSource = x;

            prebuild[] listprebuild = new prebuild[dg.Rows.Count - 1];

            for (int i = 0; i < listprebuild.Length; i++)
            {
                listprebuild[i] = new prebuild();
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
        private void minP_OnValueChanged(object sender, EventArgs e)
        {
            btn_ok.Visible = true;
        }

        private void maxP_OnValueChanged(object sender, EventArgs e)
        {
            btn_ok.Visible = true;
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            clears();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            clears();

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

        private void minP_OnValueChanged_1(object sender, EventArgs e)
        {
            btn_ok.Visible = true;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Main.main.newbuildclick();
        }

        public void clears()
        {
            tableLayoutPanel1.Controls.Clear();
            if (minP.Text!="" && maxP.Text!= "")
            {
                min = Convert.ToInt32(minP.Text);
                max = Convert.ToInt32(maxP.Text);
                string a = Searchtxt.Text;

                if (bunifuCheckbox1.Checked && bunifuCheckbox3.Checked) builds(min, max, a, "INTEL", "G-Sync");
                if (bunifuCheckbox1.Checked && bunifuCheckbox4.Checked) builds(min, max, a, "INTEL", "Freesync");
                if (bunifuCheckbox2.Checked && bunifuCheckbox3.Checked) builds(min, max, a, "AMD", "G-Sync");
                if (bunifuCheckbox2.Checked && bunifuCheckbox4.Checked) builds(min, max, a, "AMD", "Freesync");
            }
        }

    }
}
