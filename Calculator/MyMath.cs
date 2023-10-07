using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MyMath
    {
        public double Addition(double x, double y)
        {
            return x + y;
        }
        public double Subtraction(double x, double y)
        {
            return x - y;
        }
        public double Multiplication(double x, double y)
        {
            return x * y;
        }
        public double Division(double x, double y)
        {
            return x / y;
        }
        public double Power(double x, double y)
        {
            double newNumber = 1;
            for(int i = 0; i < y; i++)
            {
                newNumber *= x;
            }

            return newNumber;
        }
    }
}
