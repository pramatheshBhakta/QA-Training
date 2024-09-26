using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumCsharp.Selenium
{
    internal class LaunchChrome
    {
        [SetUp]
        public void startBrowser()
        {
            //Configfure web driver manager.
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            //Initialize chrome driver
            ChromeDriver driver = new ChromeDriver();

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
