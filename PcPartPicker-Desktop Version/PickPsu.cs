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
    public partial class PickPsu : UserControl
    {
        databeuseDataContext db = new databeuseDataContext();
        public PickPsu()
        {
            InitializeComponent();
            powersupply("");
        }
        int poss = 10;


        public void addItem(string text, string path)
        {
            AddPart p = new PcPartPicker_Desktop_Version.AddPart(text, path);
            panel1.Controls.Add(p);
            p.Top = poss;
            poss = (p.Top + p.Height + 5);

        }

        public void powersupply(String Filter)
        {
            List<PowerSupply> b6 = new List<PowerSupply>();
            var q6 = (from a in db.PowerSupplies
                      where a.Wattage>= Main.WATTAGE
                      select a).ToList();
            b6 = q6;
            dataGridView1.DataSource = b6;

            int i6 = b6.Count();
            for (int a = 0; a < i6; a++)
            {

                string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                addItem(c, "PowerSupply");
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            poss = 10;
            panel1.Controls.Clear();

            powersupply(bunifuMaterialTextbox1.Text);
        }

        private void cbAMD_OnChange(object sender, EventArgs e)
        {
            clears();
        }
        public void clears()
        {


            panel1.Controls.Clear();
            poss = 10;
            string a = bunifuMaterialTextbox1.Text;
            if (cbAMD.Checked) PSUS("Fully Modular",a);
            if (cbIntel.Checked) PSUS("Semi-Modular",a);
            if (bunifuCheckbox1.Checked) PSUS("NONE",a);

        }

        public void PSUS(string Filter,string b)

        {
            dataGridView1.Controls.Clear();
            List<PowerSupply> b6 = new List<PowerSupply>();
            var q6 = (from a in db.PowerSupplies
                      where a.Modular == (Filter)  && a.PowerSupply_ID.Contains(b)
                      select a).ToList();
            b6 = q6;
            dataGridView1.DataSource = b6;

            int i6 = b6.Count();
            for (int a = 0; a < i6; a++)
            {

                string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                addItem(c, "PowerSupply");
            }
        }

        private void cbIntel_OnChange(object sender, EventArgs e)
        {
            clears();
        }

        private void PickPsu_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            clears();
        }
    }
}
