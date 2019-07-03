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
            driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html?UserName=5712654&Password=5546464&Login=Login");
            Console.WriteLine("Get to page");
        }

        [Test]
        public void TestExecution()
        {
            //Title selection
            googleTest.SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

            //Initial filling
            googleTest.SeleniumSetMethods.EnterText(driver, "Initial", "Roman", "Name");

            //Click Save button
            googleTest.SeleniumSetMethods.ClickSmth(driver, "Save", "Name");


            
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Close the browser");
        }

    }
}