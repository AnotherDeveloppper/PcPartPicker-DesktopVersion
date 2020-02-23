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
    public partial class PickCpuCooler : UserControl
    {
        databeuseDataContext db = new databeuseDataContext();
        public PickCpuCooler()
        {
            InitializeComponent();
            CpuCooler("");

        }

        int poss = 10;
        public void addItem(string text, string path)
        {
            AddPart p = new PcPartPicker_Desktop_Version.AddPart(text, path);
            panel1.Controls.Add(p);
            p.Top = poss;
            poss = (p.Top + p.Height + 5);

        }
        public void CpuCooler(String Filter)
        {
            List<CpuCooler> b3 = new List<CpuCooler>();
            var q3 = (from a in db.CpuCoolers
                      where a.CpuCooler_ID.Contains(Filter)
                      select a).ToList();
            b3 = q3;
            dataGridView1.DataSource = b3;

            int i3 = b3.Count();
            for (int a = 0; a < i3; a++)
            {

                string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                addItem(c, "CpuCooler");
            }
        }

        private void cbAMD_OnChange(object sender, EventArgs e)
        {
            
        }
    }
    }
