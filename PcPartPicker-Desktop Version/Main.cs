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
    public  partial class Main : Form
    {

        databeuseDataContext db = new databeuseDataContext();
        string name, password;


        int loop =1;



        AllParts form4;
        UserSettings form5;
        prebuilds f1;
        NewBuild form3;
        prebuildpage f2;

        public Main(String a, String b)
        {
            InitializeComponent();
            name = a;
            password = b;
            pictureBox1.BackColor = Color.Transparent;

            form3 = new NewBuild();
            form4 = new AllParts();
            form5 = new UserSettings(name,password);
            f1 = new prebuilds();
            f2 = new prebuildpage();
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
            f1.Hide();
            form5.Hide();
            form4.Hide();
            naming.Text = bunifuFlatButton3.Text;
            form3.Dock = DockStyle.Fill;
            Workhere.Controls.Add(form3);
            form3.Show();
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
            f1.Hide();
            form5.Hide();
            naming.Text = bunifuFlatButton5.Text;
            form4.Dock = DockStyle.Fill;
            Workhere.Controls.Add(form4);
            form4.Show();

          
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            f1.Hide();
            naming.Text = "User Settings";
            form4.Hide();
            form5.Dock = DockStyle.Fill;
            Workhere.Controls.Add(form5);
            form5.Show();
        }

        public void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            form4.Hide();
            form5.Hide();
            naming.Text = bunifuFlatButton4.Text;
            f1.Dock = DockStyle.Fill;
            Workhere.Controls.Add(f1);
            f1.Show();
          
        }


        private void allParts1_Load(object sender, EventArgs e)
        {

        }
        private void Workhere_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            var q = from a in db.USER
                    where a.UserName == name && a.Password == password
                    select a;

            bunifuFlatButton2.Text = "                  " + name;
            dataGridView1.DataSource = q;
            
            //pictureBox2.Image = Image.FromFile(@"images\"+ dataGridView1.Rows[0].Cells[8].Value.ToString());
        }
        public static void  testc()
        {
            MessageBox.Show("ksksk");
            

        }

        



    }
}
