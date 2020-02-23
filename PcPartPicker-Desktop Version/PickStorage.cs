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
    public partial class PickStorage : UserControl
    {
        databeuseDataContext db = new databeuseDataContext();
        public PickStorage()
        {
            InitializeComponent();
            Storage("");
        }
        int poss = 10;
        public void addItem(string text, string path)
        {
            AddPart p = new PcPartPicker_Desktop_Version.AddPart(text, path);
            panel1.Controls.Add(p);
            p.Top = poss;
            poss = (p.Top + p.Height + 5);

        }
        public void Storage(String Filter)
        {
            List<Storage> b7 = new List<Storage>();
            var q7 = (from a in db.Storages
                      where a.Storage_ID.Contains(Filter)
                      select a).ToList();
            b7 = q7;
            dataGridView1.DataSource = b7;

            int i7 = b7.Count();
            for (int a = 0; a < i7; a++)
            {

                string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                addItem(c, "Storage");
            }
        }
    }
}
