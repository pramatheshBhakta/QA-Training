using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCsharp.NUnitTest
{
    internal class FactorialUnitTest
    {
        Factorial facty = new Factorial();
        [Test]
        public void Factcheck()
        {
            int res = facty.fact(3);
            Assert.AreEqual(6, res);
        }
    }
}
