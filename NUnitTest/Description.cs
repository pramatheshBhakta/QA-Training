using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCsharp.NUnitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class Description
    {
        [Description("This Test verifies the login functionality with  valid credentials")]
        [Test]
        
        public void testCase()
        {
            Console.WriteLine("This is the first test Case");
        }
    }
}
