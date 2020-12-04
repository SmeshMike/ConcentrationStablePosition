using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcentrationStablePosition
{
    class MathsStuff
    {
        private double _nd, _t, _environmentEpsilon, _u0, _l, _n0, _epsilon, _fi, _q, _dfiStart, _dfiEnd, _fiStart, _fiEnd, _kx, _b;
        private readonly double _k = 1.380649 * Math.Pow(10, -23);
        private readonly double _e = - 1.602176 * Math.Pow(10, -19);
        private readonly double _epsilon0 = 8.854187 * Math.Pow(10, -12);




        public double T { get; set; }
        public double EnvironmentEpsilon { get; set; }
        public double U0 { get; set; }
        public double L { get; set; }

        private double Fi0 => _k * _t / _q;
        private double Xi0 => Math.Sqrt(_k * _t * _epsilon0 * _epsilon/ (_q*_q));
        private double Nd => _nd * _n0;

        double Q(double fi, double nd)
        {
            return fi * Math.Pow(Math.E, fi) * nd;
        }

        double R(double fi, double nd)
        {
            return Q(fi, nd)*fi + nd*(1 - Math.Pow(Math.E, fi));
        }

        private double _k1, _k2, _k3, _k4, _z, _alpha, _beta;

        double K(double x)
        {
            return _kx * x + _b;
        }


        void ChasingMethod(double start, double end, int direction, double step)
        {

            _k1 = _q;
            _k2 = _q + step/2 - _k1*(step/2)* (step / 2);
            _k3 = _q + step / 2 - _k2 * step / 2;
            _k4 = _q + step - ;
        }

    }
}
