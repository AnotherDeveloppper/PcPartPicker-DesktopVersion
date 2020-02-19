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

            

        }

        
        



        private void builds ()
        {
            var x = from a in db.BUILDs select a;
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

        private void minP_OnValueChanged(object sender, EventArgs e)
        {
            btn_ok.Visible = true;
        }

        private void maxP_OnValueChanged(object sender, EventArgs e)
        {
            btn_ok.Visible = true;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            min = Convert.ToInt32(minP.Text);
            max = Convert.ToInt32(maxP.Text);
            MessageBox.Show(min + " " + max);
        }
    }
}
