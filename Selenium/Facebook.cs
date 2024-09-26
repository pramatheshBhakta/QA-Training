using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumCsharp.Selenium
{
    internal class Facebook
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
            driver.Navigate().GoToUrl("https://www.facebook.com/login/");

        }




        [Test]
        public void testcase1()
        {
            IWebElement gmail = driver.FindElement(By.XPath("//input[@id='email']"));
            gmail.Click();
            new Actions(driver)
                .KeyDown(Keys.Shift)
                .SendKeys("p")
                .KeyUp(Keys.Shift)
                .SendKeys("ramathesh")
                .KeyDown(Keys.Shift)
                .SendKeys("2")
                .SendKeys("g")
                .KeyUp (Keys.Shift)
                .SendKeys("mail.")
                .KeyDown(Keys.Shift)
                .SendKeys("c")
                .KeyUp(Keys.Shift)
                .SendKeys("om")
                .Perform();

            Thread.Sleep(2000);
            new Actions(driver)
                .KeyDown(Keys.Control)
                .SendKeys("a")
                .KeyUp(Keys.Control)
                .Perform();
                

            Thread.Sleep(2000);
            new Actions(driver)
                .KeyDown(Keys.Control)
                .SendKeys("x")
                .KeyUp(Keys.Control)
                .Perform();

            gmail.Click();
            Thread.Sleep(2000);
            new Actions(driver)
                .KeyDown(Keys.Control)
                .SendKeys("v")
                .KeyUp(Keys.Control)
                .Perform();

            Thread.Sleep(3000);
            /*new Actions(driver)
               .KeyUp(Keys.Shift)
               .SendKeys("A")
               .Perform();
            Thread.Sleep(2000);*/

        }


        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
