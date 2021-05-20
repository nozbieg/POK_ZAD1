using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POK_ZAD1
{
    public class CubeVolume
    {
        public CubeVolume(double side)
        {
            Side = side;
        }
        public double Side { get; set; }

        private double volume;
        public double Volume
        {
            get
            {
                volume = Math.Pow(Side, 3);
                return volume;
            }
        }

        public override string ToString()
        {
            return "Cube Side is: " + Side + ", Cube Volume is: " + Volume;
        }


    }
}
