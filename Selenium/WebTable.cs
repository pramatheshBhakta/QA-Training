using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Firefox;

namespace NUnitSeleniumCsharp.Selenium
{
    internal class WebTable
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            // intialize the web driver 
            driver = new EdgeDriver();
            // launch the forefox browser

            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {

            // xpath of the html web table

            IWebElement table = driver.FindElement(By.XPath("//table[@id = 'product']"));

            // fetch the all rows of the table

            List<IWebElement> trrow = new List<IWebElement>(table.FindElements(By.XPath("//table[@id = 'product']/tbody/tr")));

            int rowcount = trrow.Count();

            Console.WriteLine(rowcount);

            // fecth the no of columns

            List<IWebElement> tdcol = new List<IWebElement>(table.FindElements(By.XPath("//table[@id = 'product']/tbody/tr[8]/td")));

            int colcount = tdcol.Count();

            Console.WriteLine(colcount);

            // cell data

            IWebElement celldata = driver.FindElement(By.XPath("//table[@id = 'product']/tbody/tr[8]/td[2]"));

            string text = celldata.Text;

            Console.WriteLine(text);

            
        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }

    }
}
