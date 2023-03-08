using DSAlgoPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgoUnitTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Calculator_AddTest()
        {
            Calculator calculator = new Calculator();
            int sum = calculator.sum(1, 2);
            Assert.AreEqual(3, sum,0,"Sum incorrect");
        }
    }
}
