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
    public partial class AllParts : UserControl
    {
        databeuseDataContext db = new databeuseDataContext();
        public AllParts()
        {
            InitializeComponent();
        }

        int poss = 10;
        public void addItem(string text)
        {
            Part p = new PcPartPicker_Desktop_Version.Part(text);
            panel2.Controls.Add(p);
            p.Top = poss;
            poss = (p.Top + p.Height + 5 );

        }
        public void addItem(string text,string path)
        {
            Part p = new PcPartPicker_Desktop_Version.Part(text,path);
            panel2.Controls.Add(p);
            p.Top = poss;
            poss = (p.Top + p.Height + 5);

        }
        private void AllParts_Load(object sender, EventArgs e)
        {
            List<Gpu> b = new List<Gpu>();
            var q = (from a in db.Gpus
                    select a).ToList();
            b = q;
            dataGridView1.DataSource = b;
            
            int i = b.Count();
             for(int a =0;a<i;a++)
              {

            string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                 addItem(c);
              }


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
        }
    }
}
