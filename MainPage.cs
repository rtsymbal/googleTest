using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace googleTest
{
    class MainPage : PropertiesCollection
    {
        //private IWebDriver driver;

        //public MainPage(IWebDriver _driver) => driver = _driver;

        private IWebElement DropDown => Driver.FindElement(By.Id("TitleId"));
        public void SelectDd(string value) => new SelectElement(DropDown).SelectByText(value);

        private IWebElement InitialTxt => Driver.FindElement(By.Name("Initial"));
        public void InputTxt(string value) => InitialTxt.SendKeys(value);

        private IWebElement BTNSave => Driver.FindElement(By.Name("Save"));
        public void ClickSave() => BTNSave.Click();

    }


}
