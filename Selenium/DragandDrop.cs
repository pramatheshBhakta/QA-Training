using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace NUnitSeleniumCsharp.Selenium
{
    internal class DragandDrop
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com//drag_and_drop");

        }




        [Test]
        public void testcase1()
        {
           

            IWebElement Source = driver.FindElement(By.XPath("//div[@id='column-a']"));

            IWebElement Dest = driver.FindElement(By.XPath("//div[@id='column-b']"));

            new Actions(driver)
                .DragAndDrop(Source, Dest)
                .Perform();
            Thread.Sleep(1000);
        }


        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
