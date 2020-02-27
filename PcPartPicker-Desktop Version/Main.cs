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
        public static string name, password;
        public string uid;
        int loop = 0;
        public static  int WATTAGE;
        public static double PRICE;
        public static String cp,gp,mem,mobo,cpc,ssd,psp,chase;
        public static Main main;
        public static int PcPartsLoop = 0;
        AllParts form4;
        UserSettings form5;
        prebuilds f1;
        prebuildpage f2;
        mainpanel m1;
        NewBuild n1;
        PickCpu p1;
        PickCpuCooler p2;
        PickMobo p3;
        PickRam p4;
        PickStorage p5;
        PickGpu p6;
        PickPsu p7;
        PickCase p8;
        ShowNewBuild p9;
        urbuilds u1;
        AdminParts ad;
        partpage pg;

        public Main(String a, String b)
        {
            InitializeComponent();
            name = a;
            password = b;
            pictureBox1.BackColor = Color.Transparent;
            
            form4 = new AllParts();
            form5 = new UserSettings(name, password);
            f1 = new prebuilds();
            f2 = new prebuildpage();
            m1 = new mainpanel();
            n1 = new NewBuild();
            p1 = new PickCpu();
            p2 = new PickCpuCooler();
            p4 = new PickRam();
            p5 = new PickStorage();
            p6 = new PickGpu();
            p7 = new PickPsu();
            p8 = new PickCase();
            ad = new AdminParts();
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

        public void resetyourbuilds()
        {
            Workhere.Controls.Remove(u1);
            yourbuildsclick();
        }
        public void newbuildclick()
        {

            u1 = new urbuilds();
            if (Workhere.Controls.Contains(u1)) u1.Hide();
            letHide("");
            f1.Hide();
            u1.Hide();
            form5.Hide();
            form4.Hide();
            naming.Text = bunifuFlatButton3.Text;
            f2.Hide();
            m1.Hide();
            ad.Hide();
            n1.Dock = DockStyle.Fill;
            Workhere.Controls.Add(n1);
            n1.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            yourbuildsclick();
            ad.Hide();
            letHide("");
            
        }

        public void yourbuildsclick()
        {

            u1 = new urbuilds();
            f1.Hide();
            form5.Hide();
            form4.Hide();
            n1.Hide();
            f2.Hide();
            m1.Hide();
            u1.Dock = DockStyle.Fill;
            Workhere.Controls.Add(u1);
            u1.Show();
            letHide("");
            naming.Text = bunifuFlatButton1.Text;

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            u1 = new urbuilds();
            m1.Hide();
            form5.Hide();
            f2.Hide();
            f1.Hide();
            form4.Dock = DockStyle.Fill;
            Workhere.Controls.Add(form4);
            form4.Show();
            u1.Hide();
            n1.Hide();
            ad.Hide();
            letHide("");

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
            n1.Hide();
            form4.Hide();
            form5.Hide();
            f2.Hide();
            f1.Hide();
            m1.Dock = DockStyle.Fill;
            Workhere.Controls.Add(m1);
            m1.Show();
            u1.Hide();

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            u1 = new urbuilds();
            ad.Hide();
            n1.Hide();
            letHide("");
            f1.Hide();
            naming.Text = "User Settings";
            form4.Hide();
            form5.Dock = DockStyle.Fill;
            Workhere.Controls.Add(form5);
            form5.Show();
            f2.Hide();
            m1.Hide();
            u1.Hide();

        }

        public void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            prebuildsclick();
            letHide("");
            ad.Hide();

        }
        public void prebuildsclick()
        {
            u1 = new urbuilds();
            form4.Hide();
            form5.Hide();
            naming.Text = bunifuFlatButton4.Text;
            f1.Dock = DockStyle.Fill;
            Workhere.Controls.Add(f1);
            f1.Show();
            f2.Hide();
            m1.Hide();
            n1.Hide();
            u1.Hide();

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

            bunifuFlatButton2.Iconimage = Image.FromFile(@"images\"+ dataGridView1.Rows[0].Cells[8].Value.ToString());
            uid= dataGridView1.Rows[0].Cells[0].Value.ToString();

            //mainpanel load
            form4.Hide();
            form5.Hide();
            m1.Dock = DockStyle.Fill;
            Workhere.Controls.Add(m1);
            f1.Show();
            f2.Hide();

            //
            if (Main.main.uid == "1" || Main.main.uid == "2" || Main.main.uid == "3")
            {
                bunifuFlatButton6.Visible = true;
            }

        }
        public void prebuildpageshow()
        {         
            form4.Hide();
            f1.Hide();
            form5.Hide();
            naming.Text = "Parts list";
            f2.Dock = DockStyle.Fill;
            Workhere.Controls.Add(f2);
            f2.Show();
            m1.Hide();
            u1.Hide();
            

        }
        public void partpageshow()
        {
            pg = new partpage(Part.typirino);
            form4.Hide();
            f1.Hide();
            form5.Hide();
            naming.Text = "Parts list";
            pg.Dock = DockStyle.Fill;
            Workhere.Controls.Add(pg);
            pg.Show();
            m1.Hide();

        }





        public void cpuCheck()
        {
            naming.Text = bunifuFlatButton4.Text;
            letHide("cpu");
            p1.Dock = DockStyle.Fill;
            Workhere.Controls.Add(p1);
            form4.Hide();
            form5.Hide();
            f1.Hide();
            p1.Show();
            f1.Hide();
            f2.Hide();
            m1.Hide();
            n1.Hide();
            PcPartsLoop = 1;
        }


        public void cpucoolerCheck()
        {
            naming.Text = bunifuFlatButton4.Text;
            letHide("cpucooler");
            p2.Dock = DockStyle.Fill;
            Workhere.Controls.Add(p2);
            form4.Hide();
            form5.Hide();
            f1.Hide();
            p2.Show();
            f1.Hide();
            f2.Hide();
            m1.Hide();
            n1.Hide();
            PcPartsLoop = 2;
            p3 = new PickMobo();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            form4.Hide();
            form5.Hide();
            f1.Hide();
            p2.Show();
            f1.Hide();
            f2.Hide();
            m1.Hide();
            n1.Hide();
            letHide("");
            ad.Dock = DockStyle.Fill;
            Workhere.Controls.Add(ad);
            ad.Show();
        }

        public void moboCheck()
        {
            naming.Text = bunifuFlatButton4.Text;
            letHide("mobo");
            p3.Dock = DockStyle.Fill;
            Workhere.Controls.Add(p3);
            form4.Hide();
            form5.Hide();
            f1.Hide();
            p3.Show();
            f1.Hide();
            f2.Hide();
            m1.Hide();
            n1.Hide();
            PcPartsLoop = 3;
        }
        public void ramCheck()
        {
            naming.Text = bunifuFlatButton4.Text;
            letHide("ram");
            p4.Dock = DockStyle.Fill;
            Workhere.Controls.Add(p4);
            form4.Hide();
            form5.Hide();
            f1.Hide();
            p4.Show();
            f1.Hide();
            f2.Hide();
            m1.Hide();
            n1.Hide();
            PcPartsLoop = 4;
        }
        public void storageCheck()
        {
            naming.Text = bunifuFlatButton4.Text;
            letHide("storage");
            p5.Dock = DockStyle.Fill;
            Workhere.Controls.Add(p5);
            form4.Hide();
            form5.Hide();
            f1.Hide();
            p5.Show();
            f1.Hide();
            f2.Hide();
            m1.Hide();
            n1.Hide();
            PcPartsLoop = 5;
        }
        public void gpuCheck()
        {
            naming.Text = bunifuFlatButton4.Text;
            letHide("gpu");
            p6.Dock = DockStyle.Fill;
            Workhere.Controls.Add(p6);
            form4.Hide();
            form5.Hide();
            f1.Hide();
            p6.Show();
            f1.Hide();
            f2.Hide();
            m1.Hide();
            n1.Hide();
            PcPartsLoop = 6;
        }
        public void psuCheck()
        {
            naming.Text = bunifuFlatButton4.Text;
            letHide("psu");
            p7.Dock = DockStyle.Fill;
            Workhere.Controls.Add(p7);
            form4.Hide();
            form5.Hide();
            f1.Hide();
            p7.Show();
            f1.Hide();
            f2.Hide();
            m1.Hide();
            n1.Hide();
            PcPartsLoop = 7;
        }
        public void caseCheck()
        {
            naming.Text = bunifuFlatButton4.Text;
            letHide("case");
            p8.Dock = DockStyle.Fill;
            Workhere.Controls.Add(p8);
            form4.Hide();
            form5.Hide();
            f1.Hide();
            p8.Show();
            f1.Hide();
            f2.Hide();
            m1.Hide();
            n1.Hide();
            PcPartsLoop = 8;
        }
        public void FULLBUILD()
        {
            naming.Text = bunifuFlatButton4.Text;
            letHide("");
            p9 = new ShowNewBuild();
            p9.Dock = DockStyle.Fill;
            Workhere.Controls.Add(p9);
            form4.Hide();
            form5.Hide();
            f1.Hide();
            p9.Show();
            f1.Hide();
            f2.Hide();
            m1.Hide();
            n1.Hide();
            PcPartsLoop = 9;
        }
        public void letHide(string a)
        {
            if (a != "cpu") p1.Hide();
            if (a != "cpucooler") p2.Hide();
            if (a != "mobo" && Workhere.Controls.Contains(p3)) p3.Hide();
            if (a != "ram") p4.Hide();
            if (a != "storage") p5.Hide();
            if (a != "gpu") p6.Hide();
            if (a != "psu") p7.Hide();
            if (a != "case") p8.Hide();
            if (a != "show" && Workhere.Controls.Contains(p9)) p9.Hide();
           
        }
    }
}
