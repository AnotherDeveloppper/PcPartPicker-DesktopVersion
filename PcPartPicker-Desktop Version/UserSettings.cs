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
    public partial class UserSettings : UserControl
    {

        databeuseDataContext db = new databeuseDataContext();
        string name, pass;
        public UserSettings(string username,string password)
        {
            InitializeComponent();
            name = username;
            pass = password;

        }

        private void UserSettings_Load(object sender, EventArgs e)
        {
            var q = from a in db.USERs
                    where a.UserName == name && a.Password == pass
                    select a;
            dataGridView1.DataSource = q;
       
            lblname.Text = dataGridView1.Rows[0].Cells[1].Value.ToString() + " " + dataGridView1.Rows[0].Cells[2].Value.ToString();
            txtUsername.Text = dataGridView1.Rows[0].Cells[10].Value.ToString();
            txtPassword.isPassword = true;
            txtPassword.Text= dataGridView1.Rows[0].Cells[11].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            txtEmail.Text= dataGridView1.Rows[0].Cells[5].Value.ToString();
            txtAdress.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
           lblSexe.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
            lblRole.Text = dataGridView1.Rows[0].Cells[9].Value.ToString();
            dtpBD.Value =Convert.ToDateTime( dataGridView1.Rows[0].Cells[3].Value.ToString());
            activer(false);

            pbUser.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[8].Value.ToString());
            //hey
        }
        public void activer(Boolean tr )
        {
            txtUsername.Enabled = tr;
            txtPassword.Enabled = tr;
            if(tr == true)  txtPassword.isPassword = false;
            txtPhone.Enabled = tr;
            txtEmail.Enabled = tr;
            txtAdress.Enabled = tr;
            dtpBD.Enabled = tr;
        }
    }
}
