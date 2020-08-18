using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oefeniningen17_08_2020
{
    class Counter
    {
        private int value;

        public void CounterUp()
        {
            value +=1;
        }
        public void CounterDown()
        {
            value +=1;
        }
        public void CounterReset()
        {
            value = 0;
        }
        public void ShowCounter()
        {
            MessageBox.Show(value.ToString());
        }
    }
}
