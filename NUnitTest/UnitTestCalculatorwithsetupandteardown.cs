using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCsharp.NUnitTest
{
    internal class UnitTestCalculatorwithsetupandteardown
    {
        public Calculator cl;
        [SetUp]
        public void setup()
        {
            cl = new Calculator();
            Console.WriteLine("executing the setup");

        }
        [Test]
        public void AddTest()
        {
            int result = cl.Add(2, 3);
            int result1 = cl.Add(3, -4);

            Assert.AreEqual(5, result);
            Assert.AreEqual(-1, result1);

        }
        [Test]
        public void SubTest()
        {
            int result = cl.Sub(2, 3);
            int result1 = cl.Sub(3, -4);

            Assert.AreEqual(-1, result);
            Assert.AreEqual(7, result1);

        }
        [Test]
        public void MulTest()
        {
            int result = cl.Mul(2, 3);
            int result1 = cl.Mul(3, -4);

            Assert.AreEqual(6, result);
            Assert.AreEqual(-12, result1);

        }
        [Test]
        public void DivTest()
        {
            int result = cl.Div(6, 3);
            int result1 = cl.Div(12, -4);

            Assert.AreEqual(2, result);
            Assert.AreEqual(-3, result1);

        }
        [TearDown]
        public void teardown()
        {
            Console.WriteLine("all the unit test for calculator are executed");
        }
    }
}
