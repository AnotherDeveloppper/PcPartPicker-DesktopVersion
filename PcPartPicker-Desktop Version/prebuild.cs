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
    public partial class prebuild : UserControl
    {

        public prebuild()
        {
            InitializeComponent();

           
        }
        private string _title;
        private string _builder;
        private string _gpu;
        private string _cpu;
        private string _price;
        private Image _pic;




        public string title
             {
            get { return _title; }
            set { _title = value; prebuildname.Text = value; }
             }

        public string builder
        {
            get { return _builder; }
            set { _builder = value; prebuildbuilder.Text = value; }
        }

        public string gpu
        {
            get { return _gpu; }
            set { _gpu = value; prebuildgpu.Text = value; }
        }

        public string cpu
        {
            get { return _cpu; }
            set { _cpu = value;prebuildcpu.Text = value; }
        }
        public string price
        {
            get { return _price; }
            set { _price = value;prebuildprice.Text = value.ToString(); }
        }
        public Image pic
        {
            get { return _pic; }
            set { _pic = value; prebuildpic.Image = value; }
        }

        public void prebuild_Click(object sender, EventArgs e)
        {
            
        }
    }
}
