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
    internal class HotelBooking
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
            driver.Navigate().GoToUrl("https://www.booking.com/index.en-gb.html?label=msn-HiTydpHndf_KligNqm9Sgw-79852220055838%3Atikwd-79852393960302%3Aloc-90%3Aneo%3Amte%3Alp116072%3Adec%3AqsBooking.com%29&aid=2369661&sid=d610a34830d9af64372a456808fcfc65");

        }




        [Test]
        public void testcase1()
        {
            Thread.Sleep(8000);
            IWebElement close = driver.FindElement(By.XPath("//button[@class='a83ed08757 c21c56c305 f38b6daa18 d691166b09 ab98298258 f4552b6561']"));
            close.Click();
            IWebElement Where = driver.FindElement(By.XPath("//input[@id=':rh:']"));
            Where.Click();
            Thread.Sleep(1000);
            Where.SendKeys("Mangalore");
            
            IWebElement WHen = driver.FindElement(By.XPath("//div[@class='a1139161bf']"));
            WHen.Click();
            Thread.Sleep(1000);
            
            IWebElement From = driver.FindElement(By.XPath("//span[@aria-label='24 September 2024']"));
            From.Click();

            IWebElement To = driver.FindElement(By.XPath("//span[@aria-label='28 September 2024']"));
            To.Click();

            IWebElement WHo = driver.FindElement(By.XPath("//button[@class='a83ed08757 ebbedaf8ac dbaff8df6f ada2387af8']"));
            WHo.Click();

            IWebElement minRangeInput = driver.FindElement(By.XPath("input[@class='aabf012b69' and @aria-label='Min.']]"));
            minRangeInput.Clear();
            minRangeInput.SendKeys("2000");

            // Locate the maximum range input element
            IWebElement maxRangeInput = driver.FindElement(By.XPath("input[@aria-label='Max.']"));
            maxRangeInput.Clear();
            maxRangeInput.SendKeys("10000");

            // Optionally, you can verify the values have been set
            string minValue = minRangeInput.GetAttribute("value");
            string maxValue = maxRangeInput.GetAttribute("value");
            System.Console.WriteLine("Min value: " + minValue);
            System.Console.WriteLine("Max value: " + maxValue);

        }

       

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
