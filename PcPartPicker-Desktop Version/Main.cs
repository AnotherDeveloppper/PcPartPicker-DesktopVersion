using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcPartPicker_Desktop_Version
{
    public partial class Main : Form
    {
        databeuseDataContext db = new databeuseDataContext();
        string name, password;
        public Main(String a, String b)
        {
            InitializeComponent();
            name = a;
            password = b;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var q = from a in db.USERs
                    where a.USERNAME == name && a.PASSWORD == password
                    select a;
         
        }
    }
}
