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
    internal class LaunchCrome
    {
        ChromeDriver driver;
        [SetUp]
        public void startbrowser()
        {
            //configure the web driver to setup chrome 
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //initialize
             driver=new ChromeDriver();

            //launch the browser
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");



        }
        [Test]
        public void testcase1()
        {
        }

        [TearDown] public void stopbrowser() { 
        driver.Close();
        }    

    }
}
