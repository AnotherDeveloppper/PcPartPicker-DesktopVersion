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
        int loop =1; 
        public Main(String a, String b)
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
            Application.Exit();
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
            naming.Text = bunifuFlatButton3.Text;
        }

        private void Workhere_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            naming.Text = bunifuFlatButton1.Text;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            naming.Text = bunifuFlatButton5.Text;
            //   allParts1.BringToFront();
            allParts1.BringToFront();

          
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            naming.Text = bunifuFlatButton2.Text;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            naming.Text = bunifuFlatButton4.Text;
        }

        private void allParts1_Load(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            var q = from a in db.USERs
                    where a.UserName == name && a.Password == password
                    select a;

            bunifuFlatButton2.Text = "                  " + name;


           

        }
    }
}
