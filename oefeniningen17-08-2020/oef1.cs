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
    public partial class oef1 : Form
    {
        public oef1()
        {
            InitializeComponent();
        }

        Counter myCounter = new Counter();


        private void button1_Click(object sender, EventArgs e)
        {
            myCounter.ShowCounter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myCounter.CounterUp();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myCounter.CounterDown();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myCounter.CounterReset();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
