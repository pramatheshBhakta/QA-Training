using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSeleniumCsharp.Utilities;
using OpenQA.Selenium;

namespace NUnitSeleniumCsharp.TestParam
{
    internal class TestParam : Base
    {
       
        [TestCase("Pram", "asdfg123")]
        [TestCase("Hero", "qwert")]
        public void testcase1(string user, string pass)
        {
            Thread.Sleep(1000);

            IWebElement Username = driver.FindElement(By.Name("username"));
            Username.SendKeys(user);

            Thread.Sleep(4000);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys(pass);

            IWebElement LoginButton = driver.FindElement(By.XPath("//button [@type = 'submit']"));
            LoginButton.Click();

            /*IWebElement admin = driver.FindElement(By.XPath("//li[8]"));
            Assert.NotNull(admin);*/
            Thread.Sleep(3000);
            IWebElement Errmsg = driver.FindElement(By.XPath("//div[@class='oxd-alert-content oxd-alert-content--error']"));
            string error= Errmsg.Text;

            Console.WriteLine(error);
            Assert.AreEqual("Invalid credentials",error);

        }
    }
}
