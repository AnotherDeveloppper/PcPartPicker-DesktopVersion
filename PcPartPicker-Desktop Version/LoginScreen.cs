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
    public partial class LoginScreen : Form
    {
        databeuseDataContext db = new databeuseDataContext();
        
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image
            bunifuMaterialTextbox2.isPassword = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var q = from a in db.USERs
                    where bunifuMaterialTextbox1.Text ==a.UserName && bunifuMaterialTextbox2.Text ==a.Password
                    select a;


            if (q.Count() > 0)
            {
                Main a = new Main(bunifuMaterialTextbox1.Text,bunifuMaterialTextbox2.Text);
                a.Show();
                this.Hide();
             
            }else
            {
                MessageBox.Show("Introuvable");
            }
            q = null;
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;
         
        }

        private void bunifuMaterialTextbox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main a = new Main(bunifuMaterialTextbox1.Text, bunifuMaterialTextbox2.Text);
            a.Show();
            this.Hide();
        }
    }
}
