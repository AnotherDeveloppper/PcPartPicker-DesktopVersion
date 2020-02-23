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
    public partial class PickMobo : UserControl
    {
        databeuseDataContext db = new databeuseDataContext();
        public PickMobo()
        {
            InitializeComponent();
            Motherboard("");
        }
        int poss = 10;
        public void addItem(string text, string path)
        {
            AddPart p = new PcPartPicker_Desktop_Version.AddPart(text, path);
            panel1.Controls.Add(p);
            p.Top = poss;
            poss = (p.Top + p.Height + 5);

        }

        public void Motherboard(String Filter)
        {
            string b="";
            if (Main.cp != "")
            {
                var q = from a in db.Cpus
                        where a.Cpu_ID.Contains(Main.cp)
                        select a;
                dataGridView2.DataSource = q;
                 b = dataGridView2.Rows[0].Cells[6].Value.ToString();
            }
            List<MotherBoard> b5 = new List<MotherBoard>();
            var q5 = (from a in db.MotherBoards
                      where a.Socket___CPU.Contains(b)
                      select a).ToList();
            b5 = q5;
            dataGridView1.DataSource = b5;

            int i5 = b5.Count();
            for (int a = 0; a < i5; a++)
            {

                string c = dataGridView1.Rows[a].Cells[0].Value.ToString();
                addItem(c, "Motherboard");
            }
        }
    }
}
