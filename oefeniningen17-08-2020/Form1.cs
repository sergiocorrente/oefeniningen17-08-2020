using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oefeniningen17_08_2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                var oef = new oef1();
                oef.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var oef = new oef2();
            oef.Show();
        }
    }
}
