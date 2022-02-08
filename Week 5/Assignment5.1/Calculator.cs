﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5._1
{
    interface ICalculator
    {
        double Add(double num1, double num2);
        double Multiply(double num1, double num2);
        double Divide(double num1, double num2);
        double Subtract(double num1, double num2);
    }

    internal class Calculator : ICalculator
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}
