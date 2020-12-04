using System;
using System.Collections.Generic;

namespace ConcentrationStablePosition
{
    class MathsStuff
    {
        private double _nd, _t, _u0, _l, _n0,  _q, _dfiStart, _dfiEnd, _fiStart, _fiEnd, _b, _step;
        private readonly double _k = 1.380649 * Math.Pow(10, -23);
        private readonly double _e = - 1.602176 * Math.Pow(10, -19);
        private readonly double _epsilon0 = 8.854187 * Math.Pow(10, -12);
        private List<double> _fi = new List<double>(1000);



        public double T { get; set; }
        public double EnvironmentEpsilon { get; set; }
        public double U0 { get; set; }
        public double L { get =>_l; set => _l = value; }

        private double Nd => _nd * _n0;

        double Q(double fi, double nd)
        {
            return -fi *Math.Pow(Math.E, -fi) * nd;
        }

        double R(double fi, double nd)
        {
            return Q(fi, nd)*fi - nd*(1 - Math.Pow(Math.E, -fi));
        }

        void InitFi()
        {
            var tmpK = - 2 * _fiStart / 1000;
            for (int i = 0; i < 1000; i++)
            {
                _fi.Add(tmpK * i + _fiStart);
            }
        }

        private List<double> _alpha;
        private List<double> _beta;
        void ChasingMethodForward()
        {
            double k1, k2, k3, k4, q1, q2, q3, q4;
            List<double> alpha = new List<double>() {0};
            List<double> beta = new List<double>() {_dfiStart};
            for (int i = 0; i < 999; i++)
            {
                //k1 = Q(_fi[i], _nd) - alpha[i]* alpha[i];
                //k2  = Q(_fi[i]+ _step/2, _nd) - (alpha[i] + _step/2*k1) * (alpha[i] + _step / 2 * k1);
                //k3 = Q(_fi[i] + _step / 2, _nd) - (alpha[i] + _step / 2 * k2) * (alpha[i] + _step / 2 * k2);
                //k4 = Q(_fi[i] + _step, _nd) - (alpha[i] + _step * k1) * (alpha[i] + _step * k1);
                //alpha.Add(alpha[i] + _step/6*(k1 + 2*k2 + 2*k3 + k4));

                k1 = Q(_fi[i], _nd) - alpha[i] * alpha[i];
                q1 = R(_fi[i], _nd) - alpha[i] * beta[i];
                k2 = Q(_fi[i] + k1* _step / 2, _nd) - (alpha[i] + _step / 2 * q1) * (alpha[i] + _step / 2 * q1);
                q2 = R(_fi[i] + k1* _step / 2, _nd) - (alpha[i] + _step / 2 * q1) * (beta[i] + _step / 2 * q1);
                k3 = Q(_fi[i] + k2 * _step / 2, _nd) - (alpha[i] + _step / 2 * q2) * (alpha[i] + _step / 2 * q2);
                q3 = R(_fi[i] + k2 * _step / 2, _nd) - (alpha[i] + _step / 2 * q2) * (beta[i] + _step / 2 * q2);
                k4 = Q(_fi[i] + k3*_step, _nd) - (alpha[i] + _step * q3) * (alpha[i] + _step * q3);
                q4 = R(_fi[i] + k3 * _step, _nd) - (alpha[i] + _step * q3) * (beta[i] + _step * q3);
                alpha.Add(alpha[i] + _step / 6 * (k1 + 2 * k2 + 2 * k3 + k4));
                beta.Add(beta[i] + _step / 6 * (q1 + 2 * q2 + 2 * q3 + q4));
            }

            _alpha = alpha;
            _beta = beta;
        }
        void ChasingMethodBack()
        {
            _fi[^1] = (_dfiEnd - _beta[_beta.Count]) / _alpha[_alpha.Count];
            for (int i = _fi.Length - 2; i >= 0; i++)
            {
                _fi[i] = 
            }
            double k1, k2, k3, k4, q1, q2, q3, q4;
            List<double> alpha = new List<double>() { 0 };
            List<double> beta = new List<double>() { _dfiStart };
            for (int i = 0; i < _fi.Length - 1; i++)
            {
                //k1 = Q(_fi[i], _nd) - alpha[i]* alpha[i];
                //k2  = Q(_fi[i]+ _step/2, _nd) - (alpha[i] + _step/2*k1) * (alpha[i] + _step / 2 * k1);
                //k3 = Q(_fi[i] + _step / 2, _nd) - (alpha[i] + _step / 2 * k2) * (alpha[i] + _step / 2 * k2);
                //k4 = Q(_fi[i] + _step, _nd) - (alpha[i] + _step * k1) * (alpha[i] + _step * k1);
                //alpha.Add(alpha[i] + _step/6*(k1 + 2*k2 + 2*k3 + k4));

                k1 = Q(_fi[i], _nd) - alpha[i] * alpha[i];
                q1 = R(_fi[i], _nd) - alpha[i] * beta[i];
                k2 = Q(_fi[i] + k1 * _step / 2, _nd) - (alpha[i] + _step / 2 * q1) * (alpha[i] + _step / 2 * q1);
                q2 = R(_fi[i] + k1 * _step / 2, _nd) - (alpha[i] + _step / 2 * q1) * (beta[i] + _step / 2 * q1);
                k3 = Q(_fi[i] + k2 * _step / 2, _nd) - (alpha[i] + _step / 2 * q2) * (alpha[i] + _step / 2 * q2);
                q3 = R(_fi[i] + k2 * _step / 2, _nd) - (alpha[i] + _step / 2 * q2) * (beta[i] + _step / 2 * q2);
                k4 = Q(_fi[i] + k3 * _step, _nd) - (alpha[i] + _step * q3) * (alpha[i] + _step * q3);
                q4 = R(_fi[i] + k3 * _step, _nd) - (alpha[i] + _step * q3) * (beta[i] + _step * q3);
                alpha.Add(alpha[i] + _step / 6 * (k1 + 2 * k2 + 2 * k3 + k4));
                beta.Add(beta[i] + _step / 6 * (q1 + 2 * q2 + 2 * q3 + q4));
            }

        }
    }
}
