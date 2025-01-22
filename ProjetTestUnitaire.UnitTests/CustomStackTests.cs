using EvaluationSampleCode;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EvaluationSampleCode.CustomStack;

namespace ProjetTestUnitaires.UnitTests
{
    [TestClass]
    public class CustomStackTests
    {
        private CustomStack _customStack;

        [TestInitialize]
        public void Init()
        {
            _customStack = new CustomStack();
        }

        [TestMethod]
        public void Count_EmptyStack_ReturnsZero()
        {
           int count = _customStack.Count();

            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void Push_ListELement_AndRemoveFromStack()
        {
            int value = 10;

           
            _customStack.Push(value);

            Assert.AreEqual(1, _customStack.Count());

        }

        [TestMethod]
        public void Pop_PopEmptyStack_ResultThrowException()
        {
            Assert.ThrowsException<StackCantBeEmptyException>(() => _customStack.Pop());

        }

        [TestMethod]
        public void Pop_RemoveAndReturn_ReturnLastElement()
        {
            _customStack.Push(5);
            _customStack.Push(10);
            _customStack.Push(15);

            int pod = _customStack.Pop();

            Assert.AreEqual(15, pod);
        }
    }
}
