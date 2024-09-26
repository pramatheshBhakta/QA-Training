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
    internal class Locator
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
        driver.Navigate().GoToUrl("https://automationexercise.com/contact_us");
        driver.Manage().Window.Maximize();

    }




    [Test]
    public void testcase1()
    {
        Thread.Sleep(5000);
        IWebElement Name = driver.FindElement(By.Name("name"));
        Name.SendKeys("Hero");

        IWebElement Email = driver.FindElement(By.Name("email"));
        Email.SendKeys("pram.bhaks@gmail.com");

        IWebElement Subject = driver.FindElement(By.Name("subject"));
        Subject.SendKeys("LEave application");

        IWebElement Message = driver.FindElement(By.Id("message"));
        Message.SendKeys("Sick Down With FEver");
        Thread.Sleep(3000);
        IWebElement Submit = driver.FindElement(By.Name("submit"));
        Submit.Click();



        }



    [TearDown]
    public void tearDownbrowser()
    {

        driver.Close();

    }
}
}
