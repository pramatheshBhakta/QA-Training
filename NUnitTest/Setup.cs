using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCsharp.NUnitTest
{
    internal class Setup
    {
        [SetUp]
        public void setup()
        {
            Console.WriteLine("Launching chrom browser");
        }
        [Test, Order(1)]
        public void login()
        {
            Console.WriteLine("Logging into application");
        }

        [Test, Order(2)]
        public void product()
        {
            Console.WriteLine("Selecting the Product ");

        }

        [Test, Order(3)]
        public void addtoCart()
        {
            Console.WriteLine("Product added to cart");

        }
        [TearDown]
        public void tearDown()
        {
            Console.WriteLine("closing the chrome");
        }
    }
}
