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
    public partial class PickRam : UserControl
    {
        databeuseDataContext db = new databeuseDataContext();
        public PickRam()
        {
            InitializeComponent();
            Memory("");
        }
        int poss = 10;
        public void addItem(string text, string path)
        {
            AddPart p = new PcPartPicker_Desktop_Version.AddPart(text, path);
            panel1.Controls.Add(p);
            p.Top = poss;
            poss = (p.Top + p.Height + 5);

        }
        public void Memory(String Filter)
        {
            List<Memory> b2 = new List<Memory>();
            var q2 = (from a in db.Memories
                      where a.Memory_ID.Contains(Filter) 
                      select a).ToList();
            b2 = q2;
            dataGridView1.DataSource = b2;

            int i2 = b2.Count();
            for (int a = 0; a < i2; a++)
            {

                string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                addItem(c, "memory");
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
      
        }
      

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
           
        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
      
        }
      

        private void PickRam_Load(object sender, EventArgs e)
        {

            txtPrice.Text = "Total Price : " + Main.PRICE;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            poss = 10;
            panel1.Controls.Clear();


            Memory(bunifuMaterialTextbox1.Text);
        }

        private void cb4_OnChange(object sender, EventArgs e)
        {
            clears();
        }

        public  void clears()
        {
            panel1.Controls.Clear();
            poss = 10;
            string a = bunifuMaterialTextbox1.Text;
            if (cb4.Checked) Memory(4,a);
            if (cb8.Checked) Memory(8, a);
            if (cb16.Checked) Memory(16, a);
            if (cb32.Checked) Memory(32, a);
        }

        public void Memory(int Filter,string b)
        {
            dataGridView1.Controls.Clear();
            List<Memory> b2 = new List<Memory>();
            var q2 = (from a in db.Memories
                      where  a.MemorySize.ToString() == (Filter.ToString()) && a.Memory_ID.Contains(b)
                      select a).ToList();

            b2 = q2;
            dataGridView1.DataSource = b2;

            int i2 = b2.Count();
            for (int a = 0; a < i2; a++)
            {

                string c = dataGridView1.Rows[a].Cells[0].Value.ToString(); 
                addItem(c, "memory");
            }
        }

        private void cb8_OnChange(object sender, EventArgs e)
        {
            clears();
        }

        private void cb16_OnChange(object sender, EventArgs e)
        {

            clears();
        }

        private void cb32_OnChange(object sender, EventArgs e)
        {

            clears();
        }
    }
    }
