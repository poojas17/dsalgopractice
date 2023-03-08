using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgoPractice
{
    public class Calculator
    {
        public Calculator() { }
        public int sum(int x, int y) { return x + y; }


        public static void Main()
        {
            Calculator calculator = new Calculator();
            calculator.sum(1, 2);
        }
    }
}
