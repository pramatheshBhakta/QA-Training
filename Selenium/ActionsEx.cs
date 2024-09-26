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
    internal class ActionsEx
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
            driver.Navigate().GoToUrl("https://www.amazon.in/");

        }




        [Test]
        public void testcase1()
        {
            IWebElement Prime = driver.FindElement(By.XPath("(//div[@class='nav-flyout-buffer-top'])[1]"));
            IWebElement LatestMovies = driver.FindElement(By.XPath("//img[@id='multiasins-img-link']"));

            new Actions(driver)

               .MoveToElement(Prime)
               .MoveToElement(LatestMovies)
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
