using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;
using NUnitSeleniumCsharp.Utilities;

namespace NunitSeleniumTraining.Selenium
{
    internal class Links : Base
    {

        [Test]
        public void test()
        {
            IReadOnlyList<IWebElement> elements = driver.FindElements(By.TagName("a"));

            foreach (IWebElement element in elements)
            {
                Console.WriteLine(element.Text + " The URL is " + element.GetAttribute("href"));
            }

        }

    }
}
