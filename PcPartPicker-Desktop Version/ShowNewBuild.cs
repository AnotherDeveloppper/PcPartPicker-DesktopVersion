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
    public partial class ShowNewBuild : UserControl
    {
        databeuseDataContext db = new databeuseDataContext();
        int poss = 10;
        string userID;
        public void addItem(Part p)
        {
            panel1.Controls.Add(p);
            p.Top = poss;
            poss = (p.Top + p.Height + 5);

        }
        public ShowNewBuild()
        {
            InitializeComponent();
            Part part1 = new Part(Main.cp, "cpu");
            Part part2 = new Part(Main.cpc, "CpuCooler");
            Part part3 = new Part(Main.mobo, "Motherboard");
            Part part4 = new Part(Main.mem, "memory");
            Part part5 = new Part(Main.ssd, "Storage");
            Part part6 = new Part(Main.gp, "gpu");
            Part part7 = new Part(Main.psp, "PowerSupply");
            Part part8 = new Part(Main.chase, "Case");

            addItem(part1);
            addItem(part2);
            addItem(part3);
            addItem(part4);
            addItem(part5);
            addItem(part6);
            addItem(part7);
            addItem(part8);
            var q = from a in db.USERs

                    where a.UserName == Main.name && a.Password == Main.password
                    select a;
            dataGridView1.DataSource = q;
            userID = dataGridView1.Rows[0].Cells[0].Value.ToString();


            var x = from a in db.Cases where a.Case_ID == Main.chase select a;

            dataGridView2.DataSource = x;


        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

       

            if (txtbxName.Text != "")
            {
                DialogResult s = MessageBox.Show("Do you want to save this Build?", "Confirmation", MessageBoxButtons.YesNo);
                if (s == DialogResult.Yes)
                {


                    BUILD newb = new BUILD();
                    newb.Build_Name = txtbxName.Text;
                    newb.Case_ID = Main.chase;
                    newb.PowerSupply_ID = Main.psp;
                    newb.CpuCooler_ID = Main.cpc;
                    newb.Gpu_ID = Main.gp;
                    newb.Cpu_ID = Main.cp;
                    newb.Storage_ID = Main.ssd;
                    newb.MoBo_ID = Main.mobo;
                    newb.Ram_ID = Main.mem;
                    newb.USER_ID =Convert.ToInt32(userID);
                    newb.Bootable = "true";
                    newb.Total_Watt = Main.WATTAGE;
                    newb.Total_Price = Main.PRICE;
                    newb.Build_Picture=dataGridView2.Rows[0].Cells[6].Value.ToString();

                    db.BUILDs.InsertOnSubmit(newb);
                    db.SubmitChanges();
                    Main.main.yourbuildsclick();
                }
            }
        }
    }
}
