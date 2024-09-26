using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumCsharp.Selenium
{
    internal class LaunchEdge
    {
        [SetUp]
        public void startBrowser()
        {
            //Configfure web driver manager.
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

            //Initialize chrome driver
            EdgeDriver driver = new EdgeDriver();

            //Launch Chrome 
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

        }

        [Test]
        public void testcase1()
        {

        }

        [TearDown]
        public void tearDownBrowser()
        {

        }
    }
}
