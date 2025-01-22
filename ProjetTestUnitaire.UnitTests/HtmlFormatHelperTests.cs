using EvaluationSampleCode;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetTestUnitaires.UnitTests
{
    [TestClass]

    public class HtmlFormatHelperTests
    {
        private HtmlFormatHelper _htmlFormatHelper;

        [TestInitialize]
        public void Init() {

            _htmlFormatHelper = new HtmlFormatHelper();
        }
        [TestMethod]
        public void GetStrongFormat_FormatingString_ResultString()
        {
            string content = "Test Test";
            string excepted = "<b>Test Test</b>";

            var result = _htmlFormatHelper.GetBoldFormat(content);

            Assert.AreEqual(excepted, result);
        }

        [TestMethod]
        public void GetItalicFormat_FormatingString_ResultString()
        {
            string content = "Test Test";
            string excepted = "<i>Test Test</i>";

            var result = _htmlFormatHelper.GetItalicFormat(content);

            Assert.AreEqual(excepted, result);
        }

        [TestMethod]
        public void GetFormattedListElements_ListElement_ResultListUL()
        {
            List<string> list = new List<string> { "value1", "value2", "value3" };
            string excepeted = "<ul><li>value1</li><li>value2</li><li>value3</li></ul>";


            string result = _htmlFormatHelper.GetFormattedListElements(list);

            Assert.AreEqual(excepeted, result);

        }

        [TestMethod]
        public void GetFormattedListElements_EmptyList_ReturnsEmptyUl()
        {
            List<string> List = new List<string>();

            string baliseUl = "<ul></ul>";

            string result = _htmlFormatHelper.GetFormattedListElements(List);

            Assert.AreEqual(baliseUl, result);
        }

    }
}
