using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumCsharp.Selenium
{
    internal class WindowsEx
    {
        IWebDriver driver;


        [SetUp]
        public void startbrowser()
        {

            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            // intialize the web driver 
            driver = new EdgeDriver();
            // launch the chrome browser
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");

        }




        [Test]
        public void testcase1()
        {
            String currHandle = driver.CurrentWindowHandle;
            Assert.IsNotNull(currHandle);

            IWebElement Open = driver.FindElement(By.XPath("//a[normalize-space()='Click Here']"));
            Open.Click();
            Thread.Sleep(1000);
            IList<string> windowhandles = new List<string>(driver.WindowHandles);

            driver.SwitchTo().Window(windowhandles[1]);
            Thread.Sleep(1000);
            string title = driver.Title;

            Console.WriteLine(title);
            Assert.That(title, Is.EqualTo("New Window"));
            Thread.Sleep(1000);
            driver.Close();

            driver.SwitchTo().Window(windowhandles[0]);
            Thread.Sleep(1000);
            string title1 = driver.Title;

            Console.WriteLine(title1);
            Assert.That(title1, Is.EqualTo("The Internet"));


        }


        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
