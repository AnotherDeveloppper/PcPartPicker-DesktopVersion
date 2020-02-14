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
            var q = from a in db.USER
                    where a.UserName == name && a.Password == pass
                    select a;
            dataGridView1.DataSource = q;

            remplissage();
            activer(false);

            pbUser.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[8].Value.ToString());
            //hey//
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            activer(true);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo);
            if (s == DialogResult.Yes) {
                USER result = (from a in db.USER
                               where a.USER_ID == Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value)
                               select a).SingleOrDefault();
                result.UserName = txtUsername.Text;
                result.Password = txtPassword.Text;
                result.Phone = txtPhone.Text;
                result.Email = txtEmail.Text;
                result.Adress = txtAdress.Text;
                result.BirthDay = Convert.ToDateTime(dtpBD.Value);
                db.SubmitChanges();

                activer(false);
            }
            if(s == DialogResult.No)
            {

            }
        }

        public void remplissage()
        {
            lblname.Text = dataGridView1.Rows[0].Cells[1].Value.ToString() + " " + dataGridView1.Rows[0].Cells[2].Value.ToString();
            txtUsername.Text = dataGridView1.Rows[0].Cells[10].Value.ToString();
            txtPassword.isPassword = true;
            txtPassword.Text = dataGridView1.Rows[0].Cells[11].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
            txtAdress.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
            lblSexe.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
            lblRole.Text = dataGridView1.Rows[0].Cells[9].Value.ToString();
            dtpBD.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells[3].Value.ToString());
   

            pbUser.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[8].Value.ToString());
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            remplissage();
            activer(false);

            pbUser.Image = Image.FromFile(@"images\" + dataGridView1.Rows[0].Cells[8].Value.ToString());
        }

        public void activer(Boolean tr)
        {
            txtUsername.Enabled = tr;
            if (!tr) txtUsername.BorderColorIdle = Color.Transparent; else txtUsername.BorderColorIdle = Color.Black;
            txtPassword.Enabled = tr;
            if (!tr) txtPassword.BorderColorIdle = Color.Transparent; else txtPassword.BorderColorIdle = Color.Black;
            if (tr == true) txtPassword.isPassword = false;
            txtPhone.Enabled = tr;
            if (!tr) txtPhone.BorderColorIdle = Color.Transparent; else txtPhone.BorderColorIdle = Color.Black;
            txtEmail.Enabled = tr;
            if (!tr) txtEmail.BorderColorIdle = Color.Transparent; else txtEmail.BorderColorIdle = Color.Black;
            txtAdress.Enabled = tr;
            if (!tr) txtAdress.BorderColorIdle = Color.Transparent; else txtAdress.BorderColorIdle = Color.Black;
            dtpBD.Enabled = tr;
            if (tr) dtpBD.BackColor = Color.Transparent;
            btnApply.Visible = tr;
            btnCancel.Visible = tr;
            btnEdit.Visible = !tr;


        }
    }
}
