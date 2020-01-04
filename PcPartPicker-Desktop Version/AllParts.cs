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
    public partial class AllParts : Form
    {
        databeuseDataContext db = new databeuseDataContext();
        string name, password;
        int loop =1; 
        public AllParts(String a, String b)
        {
            InitializeComponent();
            name = a;
            password = b;

            pictureBox1.BackColor = Color.Transparent;
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
            if (loop%2 == 0){
                sider.Width = 281;

                bunifuImageButton1.Location = new Point(227, 93);
            }
            else
            {

                sider.Width = 56;
                bunifuImageButton1.Location = new Point(5, 93);

            }
            loop++;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            NewBuild n = new NewBuild(name,password);
            n.ShowDialog();
        }

        private void Workhere_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            var q = from a in db.USERs
                    where a.USERNAME == name && a.PASSWORD == password
                    select a;

            bunifuFlatButton2.Text = "                  " + name;


        }
    }
}
