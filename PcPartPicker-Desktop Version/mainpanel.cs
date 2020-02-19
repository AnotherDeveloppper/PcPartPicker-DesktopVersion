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
    public partial class mainpanel : UserControl
    {
        int imgn=1;
        public mainpanel()
        {
            InitializeComponent();
        }


        private void slide()
        {
            if (imgn == 4)
            {
                imgn = 1;
            }
            sliderbox.ImageLocation = string.Format(@"images\sliderimgs\{0}.jpg", imgn);
            imgn++;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            slide();
        }

        private void mainpanel_Load(object sender, EventArgs e)
        {
            sliderbox.ImageLocation = string.Format(@"images\sliderimgs\1.jpg");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Main.main.yourbuildsclick();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.main.newbuildclick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main.main.prebuildsclick();
        }

        private void sliderbox_MouseHover(object sender, EventArgs e)
        {
           
        }
    }
}
