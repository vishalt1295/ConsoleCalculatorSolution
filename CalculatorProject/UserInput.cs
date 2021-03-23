using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
namespace CalculatorProject {


    public class UserInput {
        
        // public double _firstValue { get; set; }
        //public double _secondValue { get; set; }
        //public string userOption { get; set; }

        public UserInput() {

            Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiiplication\n4. Division\n5. Square Root\n6. Square");
            Console.Write("Enter number to select: ");
            string _userOption = Console.ReadLine();

            Console.Write("Enter first number: ");
            double _firstValue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double _secondValue = Convert.ToDouble(Console.ReadLine());
            
            Calculator _calculator = new Calculator();

            _calculator.CreateCalculation(_firstValue, _secondValue, _userOption);
        }
    }
}
