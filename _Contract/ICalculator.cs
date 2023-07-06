using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Contract
{
    public interface  ICalculator
    {
        double  Add(double a, double b);
        double Subtract(double a, double b);
        double Divide(double a, double b);

        double Multiply(double a, double b);
    }
}
