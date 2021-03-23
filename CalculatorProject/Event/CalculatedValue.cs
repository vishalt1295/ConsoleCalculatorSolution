using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.Models;
using CalculatorProject.CalculatorFunctions;

namespace CalculatorProject.Event {

    //public delegate void Notify();
    
    public class CalculatedValue {
        
        public event EventHandler CalculationCompleted;

        public void StartProcess() {
            OnCalculationCompleted(EventArgs.Empty);
        }

        protected virtual void OnCalculationCompleted(EventArgs e) {
            CalculationCompleted?.Invoke(this, e);
        }
    }
}
