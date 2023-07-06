using _Contract;
using _Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Repository
{
    public class CalculatorRepo : ICalculator
    {
        Calculator calculator = new Calculator();
        public double Add(double a, double b)
        {
            return calculator.results = (a + b);
        }

        public double Subtract(double a, double b)
        {
          return  calculator.results = (a - b);
            
        }

        public double Multiply(double a, double b)
        {
            
            return calculator.results = (a * b);
        }

        public double Divide(double a, double b)
        {
            return calculator.results = (a / b);
        }
    }
}
