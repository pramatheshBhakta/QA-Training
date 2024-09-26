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
    internal class Frames
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
            driver.Navigate().GoToUrl("https://jqueryui.com/checkboxradio/");

        }




        [Test]
        public void testcase1()
        {
            IWebElement Frame = driver.FindElement(By.XPath("//iframe[@class='demo-frame']"));
            driver.SwitchTo().Frame(Frame);
            Thread.Sleep(1000);
            IWebElement radiobutton = driver.FindElement(By.XPath("//label[@for='radio-1']"));
            radiobutton.Click();
            Thread.Sleep(1000);
        }


        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
