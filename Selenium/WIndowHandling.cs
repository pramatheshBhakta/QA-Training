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
    internal class WIndowHandling
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
            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/window_switching_tests/page_with_frame.html");

        }




        [Test]
        public void testcase1()
        {
            String currHandle = driver.CurrentWindowHandle;
            Assert.IsNotNull(currHandle);

            IWebElement Open = driver.FindElement(By.Id("a-link-that-opens-a-new-window"));
            Open.Click();
            Thread.Sleep(1000);
            IList<string> windowhandles = new List<string>(driver.WindowHandles);

            driver.SwitchTo().Window(windowhandles[1]);
            Thread.Sleep(1000);
            string title = driver.Title;

            Console.WriteLine(title);
            Assert.That(title, Is.EqualTo("Simple Page"));
            Thread.Sleep(1000);
            driver.Close();

            driver.SwitchTo().Window(windowhandles[0]);
            Thread.Sleep(1000);
            string title1 = driver.Title;

            Console.WriteLine(title1);
            Assert.That(title1, Is.EqualTo("Test page for WindowSwitchingTest.testShouldFocusOnTheTopMostFrameAfterSwitchingToAWindow"));


        }


        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
