using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public class Calculators : IAddition
    {

        public void AddTwo(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
    }
}
