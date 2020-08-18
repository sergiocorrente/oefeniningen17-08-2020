using oefeniningen17_08_2020.Properties;
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
    public partial class oef2 : Form
    {
        public oef2()
        {
            InitializeComponent();
        }

        TV mytv = new TV();
        private void oef2_Load(object sender, EventArgs e)
        {
            lbProgram.Text = mytv.programList[1];
        }
        private void btUpProgram_Click(object sender, EventArgs e)
        {
            mytv.ProgramChangeUp();
            lbProgram.Text = mytv.programList[mytv.program];

        }

        private void btDownProgram_Click(object sender, EventArgs e)
        {
            mytv.ProgramChangeDown();
            lbProgram.Text = mytv.programList[mytv.program];
        }

        private void btGotoProgram_Click(object sender, EventArgs e)
        {
            mytv.program = Convert.ToInt32(numericUpDownProgram.Value);
            if(numericUpDownProgram.Value < 15 || numericUpDownProgram.Value < 0) { 
            lbProgram.Text = mytv.programList[mytv.program];};
        }

      
    }
}
