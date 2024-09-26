﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitSeleniumTraining.Selenium
{
    internal class makemytrip
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
            driver.Navigate().GoToUrl("https://www.makemytrip.com/");
            driver.Manage().Window.Maximize();

        }




        [Test]
        public void testcase1()
        {

            IWebElement CartButton = driver.FindElement(By.XPath("//label[@for='departure']"));
            CartButton.Click();
            Thread.Sleep(3000);

        }


        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
