using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCsharp.NUnitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class AllurereportGen
    {
        
        [Test]
        public void login()
        {
            Console.WriteLine("Logging into application");
        }

        [Test]
        public void product()
        {
            Console.WriteLine("Selecting the Product ");

        }

        [Test ]
        public void addtoCart()
        {
            Console.WriteLine("Product added to cart");

        }

    }
}
