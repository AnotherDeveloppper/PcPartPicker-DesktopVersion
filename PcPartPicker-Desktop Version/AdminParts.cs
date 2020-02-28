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
    public partial class AdminParts : UserControl
    {
        databeuseDataContext db = new databeuseDataContext();
        string x;
        public AdminParts()
        {
            InitializeComponent();
            List<String> parts = new List<string> { "CPU", "CPU COOLER", "RAM", "MOTHERBOARD", "GPU", "PSU", "STORAGE", "CASE" };
            comboBox1.DataSource = parts;
        }

        private void AdminParts_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "CPU")
            {
                panelcpucooler.Hide();
                panelram.Hide();
                panelmobo.Hide();
                panelstorage.Hide();
                panelgpu.Hide();
                panelpsu.Hide();
                panelcase.Hide();
                panelcpu.Show();
                panelcpu.BringToFront();
            }
            if (comboBox1.Text == "CPU COOLER")
            {
                panelcpu.Hide();
                panelram.Hide();
                panelmobo.Hide();
                panelstorage.Hide();
                panelgpu.Hide();
                panelpsu.Hide();
                panelcase.Hide();
                panelcpucooler.Show();
                panelcpucooler.BringToFront();
            }
            if (comboBox1.Text == "RAM")
            {
                panelcpucooler.Hide();
                panelcpu.Hide();
                panelmobo.Hide();
                panelstorage.Hide();
                panelgpu.Hide();
                panelpsu.Hide();
                panelcase.Hide();
                panelram.Show();
                panelram.BringToFront();
            }
            if (comboBox1.Text == "MOTHERBOARD")
            {
                panelcpucooler.Hide();
                panelcpu.Hide();
                panelram.Hide();
                panelstorage.Hide();
                panelgpu.Hide();
                panelpsu.Hide();
                panelcase.Hide();
                panelmobo.Show();
                panelmobo.BringToFront();

            }
            if (comboBox1.Text == "GPU")
            {
                panelcpucooler.Hide();
                panelcpu.Hide();
                panelram.Hide();
                panelmobo.Hide();
                panelstorage.Hide();
                panelpsu.Hide();
                panelcase.Hide();
                panelgpu.Show();
                panelgpu.BringToFront();
            }
            if (comboBox1.Text == "PSU")
            {
                panelcpucooler.Hide();
                panelcpu.Hide();
                panelram.Hide();
                panelmobo.Hide();
                panelgpu.Hide();
                panelstorage.Hide();
                panelcase.Hide();
                panelpsu.Show();
                panelpsu.BringToFront();
            }
            if (comboBox1.Text == "STORAGE")
            {
                panelcpucooler.Hide();
                panelcpu.Hide();
                panelram.Hide();
                panelmobo.Hide();
                panelgpu.Hide();
                panelpsu.Hide();
                panelcase.Hide();
                panelstorage.Show();
                panelstorage.BringToFront();
            }
            if (comboBox1.Text == "CASE")
            {
                panelcpucooler.Hide();
                panelcpu.Hide();
                panelram.Hide();
                panelmobo.Hide();
                panelgpu.Hide();
                panelpsu.Hide();
                panelstorage.Hide();
                panelcase.Show();
                panelcase.BringToFront();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo);
            if (s == DialogResult.Yes)
            {
                Cpu c = new Cpu();
                c.Cpu_ID = bunifuMaterialTextbox1.Text;
                c.ManufacturerCpu = comboBox2.Text;
                c.Core_Count = Convert.ToInt32(bunifuMaterialTextbox2.Text);
                c.Threads_Count = Convert.ToInt32(bunifuMaterialTextbox3.Text);
                c.Core_Clock_Cpu = float.Parse(bunifuMaterialTextbox4.Text);
                c.Boost_Clock_Cpu = float.Parse(bunifuMaterialTextbox5.Text);
                c.Socket = comboBox3.Text;
                c.TDP_Cpu = Convert.ToInt32(bunifuMaterialTextbox6.Text);
                c.Maximum_Supported_Memory_Cpu = Convert.ToInt32(bunifuMaterialTextbox7.Text);
                c.Cpu_Price = Convert.ToDouble(bunifuMaterialTextbox8.Text);
                c.Integrated_Gpu = bunifuMaterialTextbox9.Text;
                c.Cpu_Picture = x;
                db.Cpus.InsertOnSubmit(c);
                db.SubmitChanges();

                MessageBox.Show("succ");
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo);
            if (s == DialogResult.Yes)
            {
                CpuCooler c = new CpuCooler();
                c.CpuCooler_ID = bunifuMaterialTextbox20.Text;
                c.ManufacturerCpuCooler = bunifuMaterialTextbox21.Text;
                c.Model_CpuCooler = bunifuMaterialTextbox12.Text;
                c.Fan_RPM = Convert.ToInt32(bunifuMaterialTextbox13.Text) + "RPM";
                c.Max_Noise_Level = Convert.ToDouble(bunifuMaterialTextbox14.Text) + "dB";
                c.Water_Cooled = comboBox4.Text;
                c.CpuCooler_Price = Convert.ToDouble(bunifuMaterialTextbox15.Text);
                c.CpuCooler_Picture = x;
                db.CpuCoolers.InsertOnSubmit(c);
                db.SubmitChanges();

                MessageBox.Show("succ");
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo);
            if (s == DialogResult.Yes)
            {
                Memory c = new Memory();
                c.Memory_ID = bunifuMaterialTextbox24.Text;
                c.ManufacturerMemory = bunifuMaterialTextbox19.Text;
                c.MemorySize = Convert.ToInt32(bunifuMaterialTextbox18.Text);
                c.Speed = Convert.ToInt32(bunifuMaterialTextbox17.Text);
                c.RAM_Slots = Convert.ToInt32(bunifuMaterialTextbox23.Text);
                c.Voltage = float.Parse(bunifuMaterialTextbox25.Text);
                c.CAS_Latency = Convert.ToInt32(bunifuMaterialTextbox26.Text);
                c.Memory_Price = Convert.ToDouble(bunifuMaterialTextbox16.Text);
                c.Memory_Picture = x;
                db.Memories.InsertOnSubmit(c);
                db.SubmitChanges();

                MessageBox.Show("succ");
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

            DialogResult s = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo);
            if (s == DialogResult.Yes)
            {
                MotherBoard c = new MotherBoard();
                c.MoBo_ID = bunifuMaterialTextbox27.Text;
                c.ManufacturerMoBo = bunifuMaterialTextbox28.Text;
                c.Socket___CPU = comboBox5.Text;
                c.Form_Factor = bunifuMaterialTextbox29.Text;
                c.Chipset_MoBo = bunifuMaterialTextbox30.Text;
                c.RAM_Slots_MoBo = Convert.ToInt32(bunifuMaterialTextbox31.Text);
                c.Max_RAM = Convert.ToInt32(bunifuMaterialTextbox32.Text);
                c.SATA_6_Gb_s = Convert.ToInt32(bunifuMaterialTextbox33.Text);
                c.M_2_Slots = Convert.ToInt32(bunifuMaterialTextbox34.Text);
                c.MoBo_Price = Convert.ToDouble(bunifuMaterialTextbox35.Text);
                c.Mobo_Picture = x;
                db.MotherBoards.InsertOnSubmit(c);
                db.SubmitChanges();

                MessageBox.Show("succ");
            }
        }

        private void btncpucool_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                x = Path.GetFileName(open.FileName);
                File.Copy(open.FileName, Path.Combine(@"images\", Path.GetFileName(open.FileName)), true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                x = Path.GetFileName(open.FileName);
                File.Copy(open.FileName, Path.Combine(@"images\", Path.GetFileName(open.FileName)), true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                x = Path.GetFileName(open.FileName);
                File.Copy(open.FileName, Path.Combine(@"images\", Path.GetFileName(open.FileName)), true);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                x = Path.GetFileName(open.FileName);
                File.Copy(open.FileName, Path.Combine(@"images\", Path.GetFileName(open.FileName)), true);
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo);
            if (s == DialogResult.Yes)
            {
                Storage c = new Storage();
                c.Storage_ID = bunifuMaterialTextbox22.Text;
                c.Manufacturer_Storage = bunifuMaterialTextbox36.Text;
                c.Capacity_storage = Convert.ToInt32(bunifuMaterialTextbox37.Text);
                c.Type_Storage = bunifuMaterialTextbox38.Text;
                c.Form_Factor_Storage = bunifuMaterialTextbox39.Text;
                c.Interface_strg = bunifuMaterialTextbox10.Text;
                c.NVME = Convert.ToInt16(comboBox6.Text);
                c.Storage_Price = Convert.ToDouble(bunifuMaterialTextbox40.Text);
                c.Storage_Picture = x;
                db.Storages.InsertOnSubmit(c);
                db.SubmitChanges();

                MessageBox.Show("succ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                x = Path.GetFileName(open.FileName);
                File.Copy(open.FileName, Path.Combine(@"images\", Path.GetFileName(open.FileName)), true);
            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo);
            if (s == DialogResult.Yes)
            {
                Gpu c = new Gpu();
                c.Gpu_ID = bunifuMaterialTextbox41.Text;
                c.Manufacturer_Gpu = comboBox8.Text;
                c.Chipset_Gpu = bunifuMaterialTextbox43.Text;
                c.Memory_Speed_Gpu = Convert.ToInt32(bunifuMaterialTextbox44.Text);
                c.Memory_Type_Gpu = bunifuMaterialTextbox45.Text;
                c.Core_Clock_Gpu = Convert.ToInt32(bunifuMaterialTextbox46.Text);
                c.Boost_Clock_Gpu = Convert.ToInt32(bunifuMaterialTextbox47.Text);
                c.Frame_Sync = comboBox7.Text;
                c.TDP_Gpu = Convert.ToInt32(bunifuMaterialTextbox48.Text);
                c.Gpu_Price = Convert.ToDouble(bunifuMaterialTextbox11.Text);
                c.Gpu_Picture = x;
                db.Gpus.InsertOnSubmit(c);
                db.SubmitChanges();

                MessageBox.Show("succ");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                x = Path.GetFileName(open.FileName);
                File.Copy(open.FileName, Path.Combine(@"images\", Path.GetFileName(open.FileName)), true);
            }
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo);
            if (s == DialogResult.Yes)
            {
                PowerSupply c = new PowerSupply();
                c.PowerSupply_ID = bunifuMaterialTextbox52.Text;
                c.Manufacturer_Psu = bunifuMaterialTextbox53.Text;
                c.Form_Factor_Psu = comboBox9.Text;
                c.Efficiency_Rating = comboBox10.Text;
                c.Wattage = Convert.ToInt32(bunifuMaterialTextbox54.Text);
                c.Modular = comboBox11.Text;
                c.Psu_Price = Convert.ToDouble(bunifuMaterialTextbox51.Text);
                c.Psu_Picture = x;
                db.PowerSupplies.InsertOnSubmit(c);
                db.SubmitChanges();

                MessageBox.Show("succ");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                x = Path.GetFileName(open.FileName);
                File.Copy(open.FileName, Path.Combine(@"images\", Path.GetFileName(open.FileName)), true);
            }
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo);
            if (s == DialogResult.Yes)
            {
                Case c = new Case();
                c.Case_ID = bunifuMaterialTextbox49.Text;
                c.Manufacturer_Case = bunifuMaterialTextbox50.Text;
                c.Type_Case = comboBox14.Text;
                c.Side_Panel_Window = comboBox13.Text;
                c.Volume = float.Parse(bunifuMaterialTextbox55.Text);
                c.Case_Price = Convert.ToDouble(bunifuMaterialTextbox42.Text);
                c.Case_Picture = x;
                db.Cases.InsertOnSubmit(c);
                db.SubmitChanges();

                MessageBox.Show("succ");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                x = Path.GetFileName(open.FileName);
                File.Copy(open.FileName, Path.Combine(@"images\", Path.GetFileName(open.FileName)), true);
            }
        }
    }
}
