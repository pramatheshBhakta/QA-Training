using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitSeleniumTraining.Selenium
{
    internal class VerticalScroll
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://www.selenium.dev/");

            chromeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {
            //Scroll down
            Thread.Sleep(5000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)chromeDriver;

            // 0 - x coordinate , 500 - y coordinate
            js.ExecuteScript("window.scrollBy(0,500)", "");

            //Scroll up
            Thread.Sleep(5000);

            // 0 - x coordinate , 500 - y coordinate
            js.ExecuteScript("window.scrollBy(0,-300)", "");

            js.ExecuteScript("window.scrollTo(0,document.body.scrollHeight)", "");


        }
        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(1000);
            chromeDriver.Dispose();
        }
    }
}
