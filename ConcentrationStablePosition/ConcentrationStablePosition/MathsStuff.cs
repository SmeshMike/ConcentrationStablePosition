using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcentrationStablePosition
{
    class MathsStuff
    {
        private double _nd, _t, _environmentEpsilon, _u0, _l, _n0, _epsilon;
        private readonly double _k = 1.380649 * Math.Pow(10, -23);
        private readonly double _q = - 1.602176 * Math.Pow(10, -19);
        private readonly double _epsilon0 = 8.854187 * Math.Pow(10, -12);

        public double T { get; set; }
        public double EnvironmentEpsilon { get; set; }
        public double U0 { get; set; }
        public double L { get; set; }

        private double Fi0 => _k * _t / _q;
        private double X0 => Math.Sqrt(_k * _t * _epsilon0 * _epsilon/ (_q*_q));
        private double Nd => _nd * _n0;

    }
}
