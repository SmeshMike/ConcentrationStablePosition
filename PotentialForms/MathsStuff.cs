using System;
using System.Collections.Generic;

namespace PotentialForms
{
    public class MathsStuff
    {
        private static double _nD, _u0, _l, _q, _dfiStart, _dfiEnd, _fiStart, _fiEnd, _step;
        public bool done = false;
        private double _ld;
        private static readonly int _size = 50;
        private static readonly double _k = 1.380649e-23;
        private static readonly double _e = - 1.602176e-19;
        private static readonly double _t = 300;
        private static readonly double _epsSi = 12;
        private static readonly double _epsVac = 8.86e-12;
        private static readonly double _n0 = 1e15;
        private static readonly double _nA = 10;
        private static List<double> _fi = new List<double>(_size);

        public static double L { get =>_l; set => _l = value; }
        public static double DFiStart { get => _dfiStart; set => _dfiStart = value; }
        public static double DFiEnd { get => _dfiEnd; set => _dfiEnd= value; }
        public static double FiStart { get => _fiStart; set => _fiStart = value;  }
        public static List<double> Fi { get => _fi; set => _fi = value; }
        public static double Nd{ get => _nD; set => _nD = value; }
        public static double N => _nD * _n0;
        

        double Q(double fi)
        {
            return - (Math.Pow(Math.E, -fi) * _nD + Math.Pow(Math.E, -fi) * _nA);
        }

        double R(double fi)
        {
            return Q(fi)*fi - _nD*(1 - Math.Pow(Math.E, -fi));
        }

        public void Init()
        {

            _ld = Math.Sqrt((_epsSi * _epsVac * _k * _t) / (_e * _e * _n0 * (_nD + _nA)));
            _l /= _ld;
            var tmpK = - 2 * _fiStart / _size;
            for (int i = 0; i < _size; i++)
            {
                _fi.Add(tmpK * i + _fiStart);
            }

            _step = _l / _size;
        }

        private List<double> _alpha;
        private List<double> _beta;
        public void RunChasingMethodForward()
        {
            double k1, k2, k3, k4, q1, q2, q3, q4;
            List<double> alpha = new List<double>() {0};
            List<double> beta = new List<double>() {_dfiStart};
            for (int i = 0; i < _size-1; ++i)
            {
                //k1 = Q(_fi[i], _nD) - alpha[i]* alpha[i];
                //k2  = Q(_fi[i]+ _step/2, _nD) - (alpha[i] + _step/2*k1) * (alpha[i] + _step / 2 * k1);
                //k3 = Q(_fi[i] + _step / 2, _nD) - (alpha[i] + _step / 2 * k2) * (alpha[i] + _step / 2 * k2);
                //k4 = Q(_fi[i] + _step, _nD) - (alpha[i] + _step * k1) * (alpha[i] + _step * k1);
                //alpha.Add(alpha[i] + _step/6*(k1 + 2*k2 + 2*k3 + k4));

                k1 = Q(_fi[i]) - alpha[i] * alpha[i];
                q1 = R(_fi[i]) - alpha[i] * beta[i];
                k2 = Q(_fi[i] + k1* _step / 2) - (alpha[i] + _step / 2 ) * (alpha[i] + _step / 2 );
                q2 = R(_fi[i] + q1* _step / 2) - (alpha[i] + _step / 2) * (beta[i] + _step / 2);
                k3 = Q(_fi[i] + k2 * _step / 2) - (alpha[i] + _step / 2 ) * (alpha[i] + _step / 2);
                q3 = R(_fi[i] + q2 * _step / 2) - (alpha[i] + _step / 2 ) * (beta[i] + _step / 2);
                k4 = Q(_fi[i] + k3*_step) - (alpha[i] + _step * q3) * (alpha[i] + _step * q3);
                q4 = R(_fi[i] + q3 * _step) - (alpha[i] + _step ) * (beta[i] + _step);
                alpha.Add(alpha[i] + _step / 6 * (k1 + 2 * k2 + 2 * k3 + k4));
                beta.Add(beta[i] + _step / 6 * (q1 + 2 * q2 + 2 * q3 + q4));
            }

            _alpha = alpha;
            _beta = beta;
        }

        private List<double> _dfi;
        public void RunChasingMethodBack()
        {
            var dfi = new List<double>();
            var fi = new List<double>
            {
                (_dfiEnd - _beta[^1]) / _alpha[^1]
            };
            dfi.Add(_dfiEnd);
            double k1, k2, k3, k4, q1, q2, q3, q4;
            
            for (int i = _fi.Count - 1; i >0; --i)
            {
                k1 = dfi[_size -1- i];
                q1 = _alpha[i] * dfi[_size - 1 - i] + _beta[i];
                k2 = dfi[_size-1 - i] + _step/2;
                q2 = (_alpha[i] + _step/2*k1)*(dfi[_size-1 - i]+_step/2) + _beta[i] + _step/2*q1;
                k3 = dfi[_size - 1 - i] + _step / 2;
                q3 = (_alpha[i] + _step / 2 * k2) * (dfi[_size-1 - i] + _step / 2) + _beta[i] + _step / 2 * q2;
                k4 = dfi[_size - 1 - i] + _step;
                q4 = (_alpha[i] + _step / 2 * k3) * (dfi[_size - 1 - i] + _step / 2) + _beta[i] + _step / 2 * q3;
                dfi.Add(dfi[_size - 1 - i] + _step / 6 * (k1 + 2 * k2 + 2 * k3 + k4));
                fi.Add(fi[_size - 1 - i] + _step / 6 * (q1 + 2 * q2 + 2 * q3 + q4));
            }
            dfi.Reverse();
            fi.Reverse();
            double eps = 0;
            for (int i = 0; i < fi.Count; i++)
            {
                eps += Math.Abs((fi[i] - _fi[i]) / fi[i]);
            }

            if (eps<0.1)
            {
                done = true;
            }
            _dfi = dfi;
            _fi = fi;
        }
    }
}
