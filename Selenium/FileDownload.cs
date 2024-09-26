using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitSeleniumTraining.Selenium
{
    internal class FileDownload
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            // intialize the web driver 
            driver = new FirefoxDriver();
            // launch the forefox browser

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {
            //HR1.png
            Thread.Sleep(1000);
          
            IWebElement downloadLink = driver.FindElement(By.LinkText("sample-1.pdf"));
            downloadLink.Click();

            // Wait for the file to download
            Thread.Sleep(5000);

            // Verify the file has been downloaded
            string filePath = "C:\\Users\\saaba\\Downloads\\sample-1.pdf";
            Assert.IsTrue(File.Exists(filePath), "File not downloaded.");
        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
