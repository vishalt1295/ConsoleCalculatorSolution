using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
namespace CalculatorProject {
    public class UserInput {
        public double _firstValue { get; set; }
        public double _secondValue { get; set; }
        public string _userOption { get; set; }
        public double _answer { get; set; }
        public UserInput() {

            Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiiplication\n4. Division\n5. Square Root\n6. Square");
            Console.Write("Enter number to select operation: ");
            _userOption = Console.ReadLine();

            Console.Write("Enter first number: ");
            _firstValue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double _secondValue = Convert.ToDouble(Console.ReadLine());
            
            Calculator _calculator = new Calculator();

            _calculator.CreateCalculation(_firstValue, _secondValue, _userOption);

            if (_userOption == "1") {
                Console.WriteLine("You selected addition");
                _answer = BulkCalculation.Sum(_firstValue, _secondValue);

                Console.WriteLine("Answer:" + _answer);

            }
            else if(_userOption == "2") {
                Console.WriteLine("You selected subtraction");
                _answer = BulkCalculation.Subtract(_firstValue, _secondValue);
                Console.WriteLine("Answer:" + _answer);
            }

            else if (_userOption == "3") {
                Console.WriteLine("You selected multiplication");
                _answer = BulkCalculation.Multiplication(_firstValue, _secondValue);
                Console.WriteLine("Answer:" + _answer);
            }
            else if (_userOption == "4") {
                Console.WriteLine("You selected division");
                _answer = BulkCalculation.Division(_firstValue, _secondValue);
                Console.WriteLine("Answer:" + _answer);
            }
            else if (_userOption == "5") {
                Console.WriteLine("You selected square root");
                _answer = BulkCalculation.SquareRoot(_firstValue);
                Console.WriteLine("Answer:" + _answer);
            }
            else if (_userOption == "6") {
                Console.WriteLine("You selected square");
                _answer = BulkCalculation.Square(_firstValue, _secondValue);
                Console.WriteLine("Answer:" + _answer);
            }


        }



    }
}
