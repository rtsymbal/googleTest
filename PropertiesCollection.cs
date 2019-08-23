using OpenQA.Selenium;

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
