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
    internal class WebShop
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
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/register");
            driver.Manage().Window.Maximize();

        }




        [Test]
        public void testcase1()
        {
            Thread.Sleep(5000);
            IWebElement Gender = driver.FindElement(By.Id("gender-male"));
            Gender.Click();

            Thread.Sleep(1000);

            IWebElement Fname = driver.FindElement(By.Name("FirstName"));
            Fname.SendKeys("Sathu");


            IWebElement Lname = driver.FindElement(By.Name("LastName"));
            Lname.SendKeys("Bangera");

            IWebElement Email = driver.FindElement(By.Name("Email"));
            Email.SendKeys("Sathu2@gmail.com");

            Thread.Sleep(1000);
            IWebElement Password = driver.FindElement(By.Name("Password"));
            Password.SendKeys("SathuGaaa");
            IWebElement ConfirmPassword = driver.FindElement(By.Name("ConfirmPassword"));
            ConfirmPassword.SendKeys("SathuGaaa");

            IWebElement RegisterButton = driver.FindElement(By.Name("register-button"));
            RegisterButton.Click();

            Thread.Sleep(5000);

        }


        [TearDown]
        public void tearDownbrowser()
        {

           driver.Close();

        }
    }

}
