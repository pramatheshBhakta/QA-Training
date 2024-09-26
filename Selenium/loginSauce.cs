using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using System.Xml.Linq;

namespace NunitSeleniumTraining.Selenium
{
    internal class loginSauce
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
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();

        }




        [Test]
        public void testcase1()
        {
            Thread.Sleep(2000);
            

            IWebElement UName = driver.FindElement(By.Name("user-name"));
            UName.SendKeys("standard_user");



            Thread.Sleep(2000);
            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("secret_sauce");

            Thread.Sleep(2000);

            IWebElement RegisterButton = driver.FindElement(By.Name("login-button"));
            RegisterButton.Click();
            Thread.Sleep(2000);

            
            IWebElement Saucelabs = driver.FindElement(By.Name("add-to-cart-sauce-labs-backpack"));
            Saucelabs.Click();
            Thread.Sleep(3000);


            IWebElement CartButton = driver.FindElement(By.XPath("//a[@class='shopping_cart_link']"));
            CartButton.Click();
            Thread.Sleep(3000);

           
            IWebElement Checkout = driver.FindElement(By.Name("checkout"));
            Checkout.Click();
            Thread.Sleep(3000);


            IWebElement Fname = driver.FindElement(By.Name("firstName"));
            Fname.SendKeys("Sathwik");



            Thread.Sleep(2000);
            IWebElement LName = driver.FindElement(By.Name("lastName"));
            LName.SendKeys("bangera");
            Thread.Sleep(2000);

            IWebElement PCode = driver.FindElement(By.Name("postalCode"));
            PCode.SendKeys("574225");
            Thread.Sleep(2000);

            IWebElement ContinueBtn = driver.FindElement(By.Name("continue"));
            ContinueBtn.Click();
            Thread.Sleep(2000);
            

            IWebElement FinishBtn = driver.FindElement(By.Name("finish"));
            FinishBtn.Click();
            Thread.Sleep(2000);

            IWebElement confirmationMessage = driver.FindElement(By.XPath("//h2[contains(text(), 'Thank you for your order!')]"));
            Assert.IsNotNull(confirmationMessage, "Order confirmation message not found!");

        }



        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
