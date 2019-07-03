using googleTest;
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
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

            //Initial filling
            SeleniumSetMethods.EnterText(driver, "Initial", "Roman", "Name");

            //Check Title value
            Console.WriteLine("The value of Title is: " + SeleniumGetMethods.GetTextFromDDL(driver, "TitleId", "Id"));

            //Check Initial value
            Console.WriteLine("The value of Initial is: " + SeleniumGetMethods.GetText(driver, "Initial", "Id"));

            //Click Save button
            SeleniumSetMethods.ClickSmth(driver, "Save", "Name");


            
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Close the browser");
        }

    }
}