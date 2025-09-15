using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace nUnitTestProject.Utils
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateDriver()
        {
            var driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}