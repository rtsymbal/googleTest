using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace googleTest
{
    [TestFixture]
    class Program
    {

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.Driver = new ChromeDriver();

            PropertiesCollection.Driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html?UserName=5712654&Password=5546464&Login=Login");
            Console.WriteLine("Get to the page");
        }

        [Test]
        public void TestExecution()
        {

            MainPage page = new MainPage();

            page.SelectDD("Mr.");
            page.InputTxt("Roman");
            page.ClickSave();


            //Title selection
            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            //Initial filling
            //SeleniumSetMethods.EnterText("Initial", "Roman", PropertyType.Name);

            //Check Title value
            Console.WriteLine("The value of Title is: " + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertyType.Id));

            //Check Initial value
            Console.WriteLine("The value of Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Id));

            //Click Save button
            //SeleniumSetMethods.ClickSmth("Save", PropertyType.Name);

        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.Driver.Close();
            Console.WriteLine("Close the browser");
        }

    }
}