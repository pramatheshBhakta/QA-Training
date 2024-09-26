using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumCsharp.NUnitTest
{
    internal class Factorial
    {
        public int fact(int a)
        {
            if (a == 0)
            { return 1; }

            return a * fact(a - 1);
        }


        public void main(string[] args)
        {
            Console.WriteLine(fact(5));
        }
    }
}
