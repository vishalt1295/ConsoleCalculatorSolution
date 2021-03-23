﻿using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.CalculatorFunctions;

namespace CalculatorProject.Models
{
    public class Calculation
    {
        public double A { get; set; }
        public double B { get; set; }
        public Func<double,double,double> Operation { get; set; }

        public Calculation(double a, double b, Func<double,double,double> calculation)
        {
            A = a;
            B = b;
            Operation = calculation;
        }

        public double GetResult()
        {
            return Operation(A, B);
        }
    }
}
