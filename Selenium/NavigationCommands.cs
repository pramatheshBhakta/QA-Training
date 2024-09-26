using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitSeleniumTraining.Selenium
{
    internal class NavigationCommands
    {

        IWebDriver driver;


        [SetUp]
        public void startbrowser()
        {

            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            // intialize the web driver 
            driver = new EdgeDriver();
            // launch the edge browser
            driver.Manage().Window.Maximize();

        }




        [Test]
        public void testcase1()
        {
            

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/checkboxes");

            Thread.Sleep(5000);
            IWebElement LoginButton = driver.FindElement(By.XPath("//input[@type = 'checkbox'])[2]"));
            LoginButton.Click();
        }


        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
