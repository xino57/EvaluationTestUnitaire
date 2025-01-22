using EvaluationSampleCode;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetTestUnitaires.UnitTests
{
    [TestClass]
    public class MathOperationsTests
    {
        private MathOperations _mathOperation;

        [TestInitialize]
        public void init()
        {
            _mathOperation = new MathOperations();

        }

        [DataRow(2, 1, 3)]
        [DataRow(3, 2, 5)]
        [DataRow(4, 3, 7)]
        [DataRow(6, 4, 10)]

        [TestMethod]
        public void Add_WithAdditionNumber_ResultNumnber(int value1, int value2, int exceptResult)
        {
            int result = _mathOperation.Add(value1, value2);

            Assert.AreEqual(exceptResult, result);

        }

        [DataRow(2, 2, 1)]
        [DataRow(9, 3, 3)]
        [TestMethod]
        public void Divide_WithValidNumber_ReturnCorrectResult(int value1, int value2, int expectedResult)
        {
            
            float result = _mathOperation.Divide(value1, value2);

            
            Assert.AreEqual(expectedResult, result);
        }


        [DataRow(2, 0)]
        [DataRow(3, 0)]
        [TestMethod]
        public void Divide_WithZeroDivisor_ThrowsArgumentException(int value1, int value2)
        {
            
            Assert.ThrowsException<ArgumentException>(() => _mathOperation.Divide(value1, value2));
        }

    }
}
