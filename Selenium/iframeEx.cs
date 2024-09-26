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
    internal class iframeEx
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/iframe");
            driver.Manage().Window.Maximize();

        }




        [Test]
        public void testcase1()
        {
            IWebElement Frame = driver.FindElement(By.XPath("//iframe[@id='mce_0_ifr']"));
            driver.SwitchTo().Frame(Frame);
            Thread.Sleep(1000);
            IWebElement paragraph = driver.FindElement(By.XPath("//p[normalize-space()='Your content goes here.']"));
            paragraph.Clear();
            paragraph.SendKeys("SHadwal is ");
            Thread.Sleep(1000);
            paragraph.SendKeys("BIGGG ");
            Thread.Sleep(2000);
            paragraph.SendKeys("HErooooo");
            Thread.Sleep(2000);
        }


        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
