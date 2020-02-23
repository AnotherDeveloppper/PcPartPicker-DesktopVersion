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
    }
}
