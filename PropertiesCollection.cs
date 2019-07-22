using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace googleTest
{

    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        ClassName,
        CssName
    }
    class PropertiesCollection
    {
        
        //Auto-implemented property
        public static IWebDriver Driver { get; set; }
        
        
    }
}
