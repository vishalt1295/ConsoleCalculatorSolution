using System;
using CalculatorProject;
using CalculatorProject.Event;
using CalculatorProject.Models;
namespace ConsoleAppProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            //Calculator class instantiation into a calculator object

            Calculator _calculator = new Calculator();
            UserInput _input = new UserInput();

            CalculatedValue cc = new CalculatedValue();

            cc.CalculationCompleted += cc_CalculationCompleted;
            cc.StartProcess();
        }

        public static void cc_CalculationCompleted(object sender, EventArgs e) {
            Console.WriteLine("Your result is: ");
        }
    }
}
