using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSeleniumCsharp.Utilities;
using OpenQA.Selenium;

namespace NUnitSeleniumCsharp.TestParam
{
    internal class TestCaseSource : Base
    {
        [Test,TestCaseSource("GetTestData")]
        public void LoginTest(string user, string pass)
        {
            Console.WriteLine(user+":"+pass);


        }
        public static IEnumerable<TestCaseData> GetTestData()
        {

            yield return new TestCaseData("abc.com", "gfgfgf");
            yield return new TestCaseData("sds.com", "jnkb");
            yield return new TestCaseData("pram.com", "nmbbjk");

        }
    }
}
