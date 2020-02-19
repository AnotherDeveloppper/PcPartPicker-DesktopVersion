﻿using System;
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

        public static String cp,gp,mem,mobo,cpc,ssd,psp,chase;
        int loop = 1;
        public static Main main;
        public static bool bahja=false;

        NewBuildParts f3;
        AllParts form4;
        UserSettings form5;
        prebuilds f1;
        NewBuild  form3;
        prebuildpage f2;
        mainpanel m1;
        

        public Main(String a, String b)
        {
            InitializeComponent();
            name = a;
            password = b;
            pictureBox1.BackColor = Color.Transparent;

            form3 = new NewBuild();
            form4 = new AllParts();
            form5 = new UserSettings(name, password);
            f1 = new prebuilds();
            f2 = new prebuildpage();
            m1 = new mainpanel();
        }

        public Main()
        {
        
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
            if (loop % 2 == 0) {
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
            newbuildclick();
        }

        private void Workhere_Paint(object sender, PaintEventArgs e)
        {


        }
        public void newbuildclick()
        {

            bahja = true;
            f1.Hide();
            form5.Hide();
            form4.Hide();
            naming.Text = bunifuFlatButton3.Text;
            form3.Dock = DockStyle.Fill;
            Workhere.Controls.Add(form3);
            form3.Show();
            f2.Hide();
            m1.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            yourbuildsclick();
        }

        public void yourbuildsclick()
        {
            // dir l code hna 
            naming.Text = bunifuFlatButton1.Text;

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

            yourbuildsclick();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            form4.Hide();
            form5.Hide();
            f2.Hide();
            f1.Hide();
            form3.Hide();
            m1.Dock = DockStyle.Fill;
            Workhere.Controls.Add(m1);
            m1.Show();
            
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            f1.Hide();
            form3.Hide();
            naming.Text = "User Settings";
            form4.Hide();
            form5.Dock = DockStyle.Fill;
            Workhere.Controls.Add(form5);
            form5.Show();
            f2.Hide();
            m1.Hide();
        }

        public void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            prebuildsclick();

        }
        public void prebuildsclick()
        {
            form4.Hide();
            form5.Hide();
            form3.Hide();
            naming.Text = bunifuFlatButton4.Text;
            f1.Dock = DockStyle.Fill;
            Workhere.Controls.Add(f1);
            f1.Show();
            f2.Hide();
            m1.Hide();
        }


        private void allParts1_Load(object sender, EventArgs e)
        {

        }
        private void Workhere_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            main = this;
            var q = from a in db.USERs
                    where a.UserName == name && a.Password == password
                    select a;

            bunifuFlatButton2.Text = "                  " + name;
            dataGridView1.DataSource = q;

            pictureBox2.Image = Image.FromFile(@"images\"+ dataGridView1.Rows[0].Cells[8].Value.ToString());


            //mainpanel load
            form4.Hide();
            form5.Hide();
            form3.Hide();
            m1.Dock = DockStyle.Fill;
            Workhere.Controls.Add(m1);
            f1.Show();
            f2.Hide();

        }
        public void prebuildpageshow()
        {
            form4.Hide();
            f1.Hide();
            form5.Hide();
            form3.Hide();
            naming.Text = "Parts list";
            f2.Dock = DockStyle.Fill;
            Workhere.Controls.Add(f2);
            f2.Show();
            m1.Hide();


        }

        public void callparts(TypePart c )
        {

            f3 = new NewBuildParts(c);

            form4.Hide();
            f1.Hide();
            form5.Hide();
            form3.Hide();
            naming.Text = "Parts list";
            f2.Hide();
            f3.Dock = DockStyle.Fill;
            Workhere.Controls.Add(f3);
            f3.Show();
            m1.Hide();

        }
        public void hideParts(NewBuild a)
        {
            

            form4.Hide();
            m1.Hide();
            f1.Hide();
            form5.Hide();
            f3.Hide();
            naming.Text = "Parts list";
            f2.Hide();
            Workhere.Controls.Remove(form3);
            a = new NewBuild(AddPart.msab);
            Workhere.Controls.Add(a);
           
        }
       

    }
}
