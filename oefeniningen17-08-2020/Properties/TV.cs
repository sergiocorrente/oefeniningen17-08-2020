using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefeniningen17_08_2020.Properties
{
    class TV
    {
        public int level { get; set; }
        public int program { get; set; }

        public List<string> programList = new List<string> { "RTB1", "RTB2", "RTL1", "Ketnet", "Uno", "Canvas", "Antenne 2", "VTM", "Vier", "Vijf", "BFM", "RT", "France Info", "Discovery" };
        public void VolumUp() {
            if (level >= 15) { level += 1; };
        }

        public void VolumDown()
        {
            if (level >= 15) { level -= 1; };
        }
        public void ProgramChangeUp()
        {
            if (program < programList.Count - 1)
            {
                program++;
            }
            else {
                program = 0;
            };
        }

        public void ProgramChangeDown()
        {
            if (program < 0)
            { program -= 1;
            } else {

                program = programList.Count - 1;
            };

      
        }

        public void ProgramChange(int nbr)
        {
            program = nbr;
        }
    }


 }

