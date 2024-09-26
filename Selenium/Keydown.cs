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
    internal class Keydown
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
            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/single_text_input.html");

        }




        [Test]
        public void testcase1()
        {
            new Actions(driver)
                .KeyDown(Keys.Shift)
                .SendKeys("Pramathesh")
                .KeyUp(Keys.Shift)
                .KeyDown(Keys.Control)
                .SendKeys("a")     
                .KeyUp (Keys.Control)
                .Perform();

            Thread.Sleep(2000);
            new Actions(driver)
                .KeyDown(Keys.Control)
                .SendKeys("x")
                .KeyUp(Keys.Control);

            Thread.Sleep(2000);
            new Actions(driver)
                .KeyDown(Keys.Control)
                .SendKeys("v")
                .KeyUp(Keys.Control);

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
