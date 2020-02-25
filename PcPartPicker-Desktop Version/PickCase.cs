 
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
    public partial class PickCase : UserControl
    {
        databeuseDataContext db = new databeuseDataContext();
        public PickCase()
        {
            InitializeComponent();
            Case("");
        }
        int poss = 10;
        public void addItem(string text, string path)
        {
            AddPart p = new PcPartPicker_Desktop_Version.AddPart(text, path);
            panel1.Controls.Add(p);
            p.Top = poss;
            poss = (p.Top + p.Height + 5);

        }
        public void Case(String Filter)
        {
            List<Case> b4 = new List<Case>();
            var q4 = (from a in db.Cases
                      where a.Case_ID.Contains(Filter)
                      select a).ToList();
            b4 = q4;
            dataGridView1.DataSource = b4;

            int i4 = b4.Count();
            for (int a = 0; a < i4; a++)
            {

                string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                addItem(c, "Case");
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            poss = 10;
            panel1.Controls.Clear();

            Case(bunifuMaterialTextbox1.Text);
        }
    }
}
