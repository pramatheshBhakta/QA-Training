using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCsharp.NUnitTest
{
    internal class Assertion
    {
        [Test]
        public void testassertion()
        {

            string Actual = " shadwal is not gay";
            string expected = "shadwal is gay";
            /*if (Actual == expected)
            {
                Console.WriteLine("The result are equal");
            }
            else
            {
                Console.WriteLine("The result are fake");
            }*/
            /*Assert.Equals(Actual, expected);
            Assert.That(Actual, Is.EqualTo(expected));*/
            Assert.That(Actual,Is.Not.EqualTo(expected));
            
        }
    }
}
