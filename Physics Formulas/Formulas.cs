using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics_Formulas
{
    public class Formulas
    {
        public double calculateVelocity(double s, double t)
        {
            double v = s / t;
            return v;
        }

        public double calculateAmperage(double P, double U)
        {
            double I = P / U;
            return I;
        }

        public double calculateElectricWork(double U, double I, double t)
        {
            double W = U * I * t;
            return W;
        }
    }
}
