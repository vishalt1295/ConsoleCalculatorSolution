using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject.Models {
    public interface AbstractFactoryCalculator {
        Calculator CreateCalculator();

    }

    /*public class ConcreteFactoryCalculator : AbstractFactoryCalculator {
        public Calculator CreateCalculator() {
            return new ConcreteCalculator();
        }

        

    } */

   

}
