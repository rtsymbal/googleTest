using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace googleTest
{
    class SeleniumGetMethods
    {
        public static string GetTextFromDdl(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return new SelectElement(PropertiesCollection.Driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault()?.Text;
            if (elementtype == PropertyType.Name)
                return new SelectElement(PropertiesCollection.Driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault()?.Text;
            else
                return String.Empty;
        }

        public static string GetText(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return PropertiesCollection.Driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementtype == PropertyType.Name)
                return PropertiesCollection.Driver.FindElement(By.Name(element)).GetAttribute("value");
            else
                return String.Empty;
        }
    }
}
