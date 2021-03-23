using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject;
using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
using System.Reflection;

namespace CalculatorProject.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void CalculatorTest()
        {
            Calculator _calculator = new Calculator();
            Assert.IsInstanceOfType(_calculator, typeof(Calculator));
        }

        [TestMethod()]
        public void SumTest()
        {
            //arrange
            double _a = 1;
            double _b =2;
            double _c;
            
            //act
            _c = BulkCalculation.Sum(_a, _b);

            //Assert
            Assert.AreEqual(_c, 3);
        }

        [TestMethod()]
        public void SubtractTest() {
            //arrange
            double _a = 2;
            double _b = 1;
            double _c;

            //act
            _c = BulkCalculation.Subtract(_a, _b);

            //Assert
            Assert.AreEqual(_c, 1);
        }

        [TestMethod()]
        public void MultiplicationTest() {
            //arrange
            double _a = 1;
            double _b = 2;
            double _c;

            //act
            _c = BulkCalculation.Multiplication(_a, _b);

            //Assert
            Assert.AreEqual(_c, 2);
        }

        [TestMethod()]
        public void DivisionTest() {
            //arrange
            double _a = 1;
            double _b = 2;
            double _c;

            //act
            _c = BulkCalculation.Division(_a, _b);

            //Assert
            Assert.AreEqual(_c, 0.5);
        }

        [TestMethod()]
        public void SquareRootTest() {
            //arrange
            double _a = 4;
            //double _b = 2;
            double _c;

            //act
            _c = BulkCalculation.SquareRoot(_a);

            //Assert
            Assert.AreEqual(_c, 2);
        }

        [TestMethod()]
        public void SquareTest() {
            //arrange
            double _a = 2;
            double _b = 2;
            double _c;

            //act
            _c = BulkCalculation.Square(_a, _b);

            //Assert
            Assert.AreEqual(_c, 4);
        }


        [TestMethod()]
        public void CalculationTest()
        {
            double _a = 1;
            double _b = 2;
            string _action = "multiplication";

            Calculator _calculator = new Calculator(_a, _b, _action);

            var _result = _calculator.Calculation[0].GetResult();
            _action = "division";

            _calculator.CreateCalculation(_a, _b, _action);

            _result = _calculator.Calculation[1].GetResult();

            _calculator.Calculation.ForEach(delegate (Calculation calculation)
            {
                Console.WriteLine(calculation.GetResult());
            });
        }

        

    }
}