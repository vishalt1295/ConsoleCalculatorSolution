using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject.CalculatorFunctions {
    public class BulkCalculation {
        public static double Sum(double a, double b) {
            double _c;
            _c = a + b;
            return _c;
        }

        public static double Subtract(double a, double b) {
            double _c;
            _c = a - b;
            return _c;
        }

        public static double Multiplication(double a, double b) {
            double _c;
            _c = a * b;
            return _c;
        }
        public static double Division(double a, double b) {
            double _c;
            _c = a / b;
            return _c;
        }
        public static double SquareRoot(double a) {
            double _c;
            _c = Math.Sqrt(a);
            return _c;
        }

        public static double Square(double a, double b) {
            double _c;
            _c = Math.Pow(a, b);
            return _c;
        }

    }
}
