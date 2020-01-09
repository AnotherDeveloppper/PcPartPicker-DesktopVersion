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
    public partial class Part : UserControl
        
    {
        databeuseDataContext db = new databeuseDataContext();
        public Part()
        {
            InitializeComponent();
        }

        public Part(string Text)
        {
            InitializeComponent();
            List<Gpu> b = new List<Gpu>();
            var q = (from a in db.Gpus
                     where a.Gpu_ID==Text
                     select a).ToList();
            b = q;
            dataGridView1.DataSource = b;

            lbItemName.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            lblPrice.Text = dataGridView1.Rows[0].Cells[9].Value.ToString() +"$";
            pbItemPic.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[10].Value.ToString());



        }
        public Part(string text, string Path)
        {
            InitializeComponent();
           
            lbItemName.Text = text;
            pbItemPic.Image = null;
            pbItemPic.Image = Image.FromFile(@"images\" + Path);
                    }

        private void Part_Load(object sender, EventArgs e)
        {

        }
    }
}
