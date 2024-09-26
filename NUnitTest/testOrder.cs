using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCsharp.NUnitTest
{
    internal class testOrder
    {
        [Test,Order(1)]
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

    }
}
