using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PcPartPicker_Desktop_Version
{
    public partial class registerPanel : UserControl
    {
        databeuseDataContext db = new databeuseDataContext();
        string pic;

        public registerPanel()
        {
            InitializeComponent();
        }

        private void registerPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {

                label1.Text = open.FileName;
                pic = Path.GetFileName(label1.Text);
            }
            
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s;


            USER u = new USER();
            u.First_Name = tb_fisrt.Text;
            u.Last_Name = tb_last.Text;
            u.Adress = tb_adress.Text;
            u.Email = tb_email.Text;
            u.UserName = tb_username.Text;
            u.Password = tb_password.Text;
            u.Phone = tb_phone.Text;
            if (male.Checked == true)
            {
                s = "m";
            }
            else { s = "f"; };
            u.Sexe = s;
            u.BirthDay = Convert.ToDateTime(tb_date.Value);
            u.User_Picture = pic;
            u.ROLE = "user";
            db.USERs.InsertOnSubmit(u);
            db.SubmitChanges();
            MessageBox.Show("register succeed mothafaaa");

            File.Copy(label1.Text, Path.Combine(@"images\", Path.GetFileName(label1.Text)), true);
            pic = Path.GetFileName(label1.Text);
            MessageBox.Show(pic);



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
