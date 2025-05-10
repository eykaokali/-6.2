using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб6._2
{
    internal interface ISolid
    {
        double GetVolume();
    }
    internal class Pyramid : ISolid
    {
        private double a;
        private double h;
        public double A
        {
            get { return a; }
            set
            {
                if (value >= 0)
                {
                    a = value;
                }
            }
        }
        public double H
        {
            get { return h; }
            set
            {
                if (value >= 0)
                {
                    h = value;
                }
            }
        }
        public double GetVolume()
        {
            return 1.0 / 3 * a * a * h;
        }
    }
    internal class Cone : ISolid
    {
        private double r;
        private double h;

        public double R
        {
            get { return r; }
            set
            {
                if (value >= 0)
                {
                    r = value;
                }
            }
        }
        public double H
        {
            get { return h; }
            set
            {
                if (value >= 0)
                {
                    h = value;
                }
            }
        }

        public double GetVolume()
        {
            return 1.0 / 3 * r * r * h;
        }
    }
}
