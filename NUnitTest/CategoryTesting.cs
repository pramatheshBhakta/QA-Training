using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCsharp.NUnitTest
{
    internal class CategoryTesting
    {
        [Test, Category("Regression")]
        public void login()
        {
            Console.WriteLine("Logging into application");
        }

        [Test, Category("Sanity, Regression")]
        public void product()
        {
            Console.WriteLine("Selecting the Product ");

        }

        [Test, Category("Sanity"),Ignore("No need of this")]
        public void addtoCart()
        {
            Console.WriteLine("Product added to cart");

        }
    }
}
