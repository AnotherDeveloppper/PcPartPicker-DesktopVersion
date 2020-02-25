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
    public partial class PickGpu : UserControl
    {
        databeuseDataContext db = new databeuseDataContext();
        public PickGpu()
        {
            InitializeComponent();
            gpu("");
        }
        int poss = 10;
        public void addItem(string text, string path)
        {
            AddPart p = new PcPartPicker_Desktop_Version.AddPart(text, path);
            panel1.Controls.Add(p);
            p.Top = poss;
            poss = (p.Top + p.Height + 5);

        }
        public void gpu(String Filter)
        {
            List<Gpu> b = new List<Gpu>();
            var q = (from a in db.Gpus
                     where a.Gpu_ID.Contains(Filter)
                     select a).ToList();
            b = q;
            dataGridView1.DataSource = b;

            int i = b.Count();
            for (int a = 0; a < i; a++)
            {

                string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                addItem(c, "gpu");
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            poss = 10;
            panel1.Controls.Clear();
            gpu(bunifuMaterialTextbox1.Text);
        }

        private void cbAMD_OnChange(object sender, EventArgs e)
        {
            clears();
        }

        private void cbIntel_OnChange(object sender, EventArgs e)
        {
            clears();
        }

        public void clears()
        {


            panel1.Controls.Clear();
            poss = 10;
            string a = bunifuMaterialTextbox1.Text;
            if (cbAMD.Checked) gpus("FreeSync",a);
            if (cbIntel.Checked) gpus("G-sync",a);
          

        }
        public void gpus(string Filter,string filter2)
        {
            List<Gpu> b = new List<Gpu>();
            var q = (from a in db.Gpus
                     where a.Frame_Sync.Equals(Filter) && a.Gpu_ID.Contains(a)
                     select a).ToList();
            b = q;
            dataGridView1.DataSource = b;

            int i = b.Count();
            for (int a = 0; a < i; a++)
            {

                string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                addItem(c, "gpu");
            }
        }
    }
}
