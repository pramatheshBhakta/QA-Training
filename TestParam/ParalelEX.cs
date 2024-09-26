using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSeleniumCsharp.Utilities;

namespace NUnitSeleniumCsharp.TestParam
{
    [Parallelizable]
    internal class ParalelEX:Base
    {
        [Parallelizable(ParallelScope.Children)]
            [Test, TestCaseSource("GetTestData")]
            public void LoginTest(string user, string pass)
            {
                DateTime crrt = DateTime.Now;
            Console.WriteLine(crrt.ToString("yyyy-MM-dd-HH-mm-ss"));
            Console.WriteLine(user + ":" + pass);


            }
            public static IEnumerable<TestCaseData> GetTestData()
            {

                yield return new TestCaseData("abc.com", "gfgfgf");
                yield return new TestCaseData("sds.com", "jnkb");
                yield return new TestCaseData("pram.com", "nmbbjk");

            }
        
    }
}
