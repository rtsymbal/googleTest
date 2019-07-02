using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestASPNETCore
{
    class Program
    {
        IWebDriver driver = new ChromeDriver("D:\\Development");

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://www.google.pl");
            Console.WriteLine("Get to Google page");
        }

        [Test]
        public void TestExecution()
        {
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("First Test");
            Console.WriteLine("Enter test in search field");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Close the browser");
        }

    }
}